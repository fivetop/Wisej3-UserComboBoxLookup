debugger;

this.myTest = function (value) {
    console.log('myTest EXECUTED!  ' + this.toString() + ' Class Name: ' + this.name + " Value: " + value);
    this.setValue("Hello!");
}

this.tst = function () {
    console.log('TextBox TST EXECUTED!  ');
}

this.tst2 = function () {
    console.log('TextBox TST2 EXECUTED!  ' + this.toString());
}
