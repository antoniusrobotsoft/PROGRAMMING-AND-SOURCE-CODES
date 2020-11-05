package intert.internet;

import java.lang.*;

/*
  Created by airhax on 8/25/16.
*/

public class RootOp {
    public FileSystemOp fso = new FileSystemOp();

    public int _TestSuBinary() {
        try {
            String cmd_log_path = "/sdcard/tcidata/command.log";
            String root_log_path = "/sdcard/tcidata/root.log";
            int is_root = 0;
            String root_fingerprint = "uid=0(root)";

            fso.ExecCmd("/system/xbin/","su -c id");
            String cmd_result = fso.read(cmd_log_path);
            fso.write(root_log_path, cmd_result);
            if (cmd_result.contains(root_fingerprint) == true) {
                is_root = 1;
            }

            return is_root;
        }
        catch (Exception e) {
            fso._do_log_debug(e,"_TestSuBinary");
            return 0;
        }
    }

    public void _check_root() {
        try {
            String root_log = "failed to root";
            int got_root = 0;
            String root_log_path = "/sdcard/tcidata/root.log";

            got_root = _TestSuBinary();
            if (got_root == 1) {
                root_log = "rooted";
                fso.write(root_log_path, root_log);
            } else {
                fso.write(root_log_path, root_log);
            }

        } catch (Exception e) {
            // Do nothing
            fso._do_log_debug(e,"_check_root");
        }
    }

}
