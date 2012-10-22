This currently has non-optimal nomenclature and is not guaranteed to be efficient, but it appears to work.

To use it, use this syntax within a unit test:


string view =
@"Please enter something: <<Something
>>You said 'Something'.";

IntelliTect.ConsoleView.Tester.Test(view, () => { MyMethod() } );


The view variable contains a sample view to test for. Within it, the << and >> symbols indicate that the inner content is entered into the console by the user -- including the newline, as they would press Enter.

... More to come later.