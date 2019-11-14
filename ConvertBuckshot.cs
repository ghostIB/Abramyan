using System;

class MainClass {
  public static void Main (string[] args) {
    string input=Input();
    if (TypeOfBuckshot(input)==1){
      string[] array=input.Split("/");
      CommonBuckshot buckshot=new CommonBuckshot(int.Parse(array[0]),int.Parse(array[1]));
      Console.WriteLine(buckshot.ConvertToDecimalBuckshot());
    }
    else{
      CommonBuckshot arr=ConvertToCommonBuckshot(Convert.ToDouble(input));
      arr.CutBuckshot();
      Console.WriteLine(arr.ToString());
    }
  }
  struct CommonBuckshot
 {
    public decimal numerator;
    public decimal denumerator;
    public decimal rate;
    public CommonBuckshot(decimal numerator, decimal denumerator){
      this.numerator=numerator;
      this.denumerator=denumerator;
      this.rate=this.numerator/this.denumerator;
      this.CutBuckshot();
    }
    public decimal ConvertToDecimalBuckshot(){
    return this.numerator/this.denumerator;
  }
    public decimal[] GetBuckshot(){
      return new decimal[] {this.numerator,this.denumerator};
    }
    public void CutBuckshot(){
      for (int i=Math.Min((int) this.numerator,(int) this.denumerator);i>0;i--){
        if (this.numerator%i==0&&this.denumerator%i==0){
          this.denumerator/=i;
          this.numerator/=i;
          break;
        }
      }
    }
    public static CommonBuckshot operator +(CommonBuckshot first,CommonBuckshot second){
      var ruteBuckshot=new CommonBuckshot(first.numerator*second.denumerator+second.numerator*first.denumerator,second.denumerator*first.denumerator);
      ruteBuckshot.CutBuckshot();
      return ruteBuckshot;
    }
    public static CommonBuckshot operator -(CommonBuckshot first,CommonBuckshot second){
      var ruteBuckshot=new CommonBuckshot(first.numerator*second.denumerator-second.numerator*first.denumerator,second.denumerator*first.denumerator);
      ruteBuckshot.CutBuckshot();
      return ruteBuckshot;
    }
    public static CommonBuckshot operator /(CommonBuckshot first,CommonBuckshot second){
      var ruteBuckshot=new CommonBuckshot(first.numerator*second.denumerator,first.denumerator*second.numerator);
      ruteBuckshot.CutBuckshot();
      return ruteBuckshot;
    }
    public static CommonBuckshot operator *(CommonBuckshot first,CommonBuckshot second){
      var ruteBuckshot=new CommonBuckshot(first.numerator*second.numerator,first.denumerator*second.denumerator);
      ruteBuckshot.CutBuckshot();
      return ruteBuckshot;
    }
    public static implicit operator decimal(CommonBuckshot obj){
      return obj.numerator/obj.denumerator;
    }
    public static implicit operator CommonBuckshot(int obj){
      return new CommonBuckshot(obj,1);
    }
    public override string ToString(){
      return String.Format("({0},{1})",this.numerator,this.denumerator);
    }
    public int GetIntPart(){
      return (int) this.ConvertToDecimalBuckshot();
    }
  }
  static string Input(){
    return Console.ReadLine();
  }
  static int TypeOfBuckshot(string buckshot){
    return buckshot.Contains("/")?1:0;
  }
  static CommonBuckshot ConvertToCommonBuckshot(double decimalBuckshot){
    string convert=Convert.ToString(decimalBuckshot);
    if (convert=="0"){
      return new CommonBuckshot(1,0);
    }
    else if (!convert.Contains(".") || convert.Substring(convert.IndexOf(".")+1)=="0"){
      return new CommonBuckshot(int.Parse(convert),1);
    }
    int len=convert.Length-1;
    int prevPoint=int.Parse(convert.Substring(0,convert.IndexOf(".")));
    int lenAfterPoint=convert.Substring(convert.IndexOf(".")+1).Length;
    if (prevPoint!=0){
      return new CommonBuckshot(Convert.ToInt32(decimalBuckshot*Math.Pow(10,lenAfterPoint)),Convert.ToInt32(Math.Pow(10,lenAfterPoint)));
    }
    else{
      for (int i=0;i<len+1;i++){
      if (convert.Substring(i,1)!="." && convert.Substring(i,1)!="0"){
        return new CommonBuckshot(int.Parse(convert.Substring(i)),Convert.ToInt32(Math.Pow(10,len-1)));
      }
    }
    }
    return new CommonBuckshot(1,0);
}
}