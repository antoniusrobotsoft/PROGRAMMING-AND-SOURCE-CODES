/*
blockrobotdaemon is an android background daemon to run BlockRobot Android App
at https://github.com/ringlayer/BlockRobot

Developer : Antonius Ringlayer
www.ringlayer.com
github.com/ringlayer

compile using android ndk !
how to compile c for android ? google is your best friend !

*/

#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <string.h>

int daemonize();
void _check_blockrobot();

int main() {
	daemonize();
	printf("\n android background process run\n");
	while (1) {
		usleep(7777777);
		printf(".");
		_check_blockrobot();
	}
}

void _check_blockrobot() {
	FILE *fp = NULL;
	int len = 0, found = 0, max_buf = 256;
	char str[256] = "\0";

	fp = popen("ps aux", "r");
	if (fp != NULL) {
		while ((fgets(str, max_buf, fp)) != NULL) {
			len = (int)strlen(str);
			if ((len > 1)) {
				if (strstr(str, "blockrobot") != NULL) {
					found = 1;
					break;
				}
			}
		}
	}
	if (fp != NULL)
		pclose(fp);
	if (found == 0) {
		system("am start -n com.ringlayer.blockrobot/.MainActivity");
	}
}

int daemonize() {
	pid_t worker_pid;

	worker_pid = fork();
	if (worker_pid != 0)
		exit(0);

	return 0;
}
