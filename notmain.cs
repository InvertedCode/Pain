namespace write {
public class Write {
public List<string> getletters(bool returnthing) {
  List<string> l = new List<string>();
  l[0]=@"a";
  l[1]=@"b";
  l[2]=@"c";
  l[3]=@"d";
  l[4]=@"e";
  l[5]=@"f";
  l[6]=@"g";
  l[7]=@"h";
  l[8]=@"i";
  l[9]=@"j";
    l[10]=@"k";
    l[11]=@"l";
  l[12]=@"m";
  l[13]=@"n";
  l[14]=@"o";
  l[15]=@"p";
  l[16]=@"q";
  l[17]=@"r";
  l[18]=@"s";
  l[19]=@"t";
  l[20]=@"u";
  l[21]=@"v";
  l[22]=@"x";
  l[23]=@"y";
  l[24]=@"and";
  l[25]=@"z";
  l[26]=@"now";
  l[27]=@"i";
  l[28]=@"know";
  l[29]=@"my";
  l[30]=@"abcs";
  l[31]=@"next";
    l[32]=@"time";
    l[33]=@"won't";
    l[34]=@"you";
    l[35]=@"sing";
    l[36]=@"with";
    l[37]=@"me";
    return l;
  }
  
  public void writeout(string a) {
    string b = a;
    string c = "";
    int i = 0;
    List<string> letters = getletters(!true);
    Console.WriteLine(b);  
  }
}
}

class oh {
static void main() {
write.Write("Hello World");
}
}
