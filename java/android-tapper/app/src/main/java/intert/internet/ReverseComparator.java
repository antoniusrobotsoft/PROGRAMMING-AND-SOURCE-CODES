package intert.internet;

import java.util.Comparator;
import java.io.Serializable;

/*
ReverseComparator class taken from Apache Commons IO
*/

public class ReverseComparator implements Comparator, Serializable {

    private final Comparator delegate;

    public ReverseComparator(Comparator delegate) {
        if (delegate == null) {
            throw new IllegalArgumentException("Delegate comparator is missing");
        }
        this.delegate = delegate;
    }

    public int compare(Object obj1, Object obj2) {
        return delegate.compare(obj2, obj1); // parameters switched round
    }

}