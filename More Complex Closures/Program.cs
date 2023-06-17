using System;

//ref link:https://www.youtube.com/watch?v=bO_9gn1eeWk&list=PLAE7FECFFFCBE1A54&index=12
// More Complex Closures

class MainClass
{
    static void Main()
    {
        Action a = GiveMeAction();
        Action b = GiveMeAction();
        b(); a(); a(); a(); b(); a();
    }

    /*class DisplayClosure
    {
        int i = 5;

        public void lambdaOne()
        {
            i++;
        }
        public void lambdaTwo()
        {
            i += 2;
        }
    }

    static Action GiveMeAction()
    {
        Action ret = null;
        // Scope
        //
        // Lambda
        //ret += () => i++;
        //ret += () => i += 2;
        var temp = new DisplayClosure();
        ret += temp.lambdaOne;
        ret += temp.lambdaTwo;
        return ret;
    }*/

    static Action GiveMeAction()
    {
        Action ret = null;
        int i = 0;
        int j = 5;
        ret += () => i++;
        ret += () => j++;
        ret += () => { i++; j++; };
        return ret;
    }
}

//Closure + Chain
// Create a class
// Add the class method1 to an Action
// Add the class method2 to the same Action
// Return the Action
// Call the Action which will call the method1 and then method 2 which are part of an instance of a class created by the compiler

