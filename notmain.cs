namespace write {
  using oWOSYSTEMCOLLECTIONSGENERICOWO = System.Collections.Generic;
  using sistm = System;
  public class Write {
static public oWOSYSTEMCOLLECTIONSGENERICOWO.List<string> getletters(bool returnthing) {
  oWOSYSTEMCOLLECTIONSGENERICOWO.List<string> l = new oWOSYSTEMCOLLECTIONSGENERICOWO.List<string>();
  l.Add(@"a");
  l.Add(@"b");
  l.Add(@"c");
  l.Add(@"d");
  l.Add(@"e");
  l.Add(@"f");
  l.Add(@"g");
  l.Add(@"h");
  l.Add(@"i");
  l.Add(@"j");
l.Add(@"k");
l.Add(@"l");
  l.Add(@"m");
  l.Add(@"n");
  l.Add(@"o");
  l.Add(@"p");
  l.Add(@"q");
  l.Add(@"r");
  l.Add(@"s");
  l.Add(@"t");
    l.Add(@"u");
  l.Add(@"v");
  l.Add(@"x");
  l.Add(@"y");
  l.Add(@"and");
  l.Add(@"z");
  l.Add(@"now");
  l.Add(@"i");
  l.Add(@"know");
  l.Add(@"my");
  l.Add(@"abcs");
  l.Add(@"next");
l.Add(@"time");
    l.Add(@"won't");
    l.Add(@"you");
    l.Add(@"sing");
    l.Add(@"with");
    l.Add(@"me");
    return l;
  }
  
  static public void writeout(string a) {
    string b = a;
    string c = "";
    int i = 0;
    oWOSYSTEMCOLLECTIONSGENERICOWO.List<string> letters = getletters(!true);
    sistm.Console.WriteLine(b);  
  }
}
}

class oh {
static void Main() {
write.Write.writeout("Hello World");
}
}
