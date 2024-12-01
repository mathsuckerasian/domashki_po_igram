public class ComplexNumber(double real, double img) {
  public double Real = real;
  public double Img = img;

  public ComplexNumber(ComplexNumber other) : this(other.Real, other.Img)
  {
  }

  public static ComplexNumber operator+(ComplexNumber lhs, ComplexNumber rhs)
  {
    return new ComplexNumber(lhs.Real + rhs.Real, lhs.Img + rhs.Img);
  }
  public static ComplexNumber operator-(ComplexNumber lhs, ComplexNumber rhs)
  {
    return new ComplexNumber(lhs.Real - rhs.Real, lhs.Img - rhs.Img);
  }
  public static ComplexNumber operator*(ComplexNumber lhs, ComplexNumber rhs)
  {
    var real = lhs.Real * rhs.Real - lhs.Img * rhs.Img;
    var img = lhs.Real * rhs.Img + rhs.Real * lhs.Img;
    return new ComplexNumber(real, img);
  }
  public static ComplexNumber operator/(ComplexNumber lhs, ComplexNumber rhs)
  {
    var res = new ComplexNumber(rhs.Real, -rhs.Img) * lhs;
    return res / (rhs.Real * rhs.Real + rhs.Img * rhs.Img);
  }
  public static ComplexNumber operator/(ComplexNumber lhs, double rhs)
  {
    return new ComplexNumber(lhs.Real / rhs, lhs.Img / rhs);
  }
  public static ComplexNumber Pow(ComplexNumber src, int pwr)
  {
    var angle = Angle(src) * pwr;
    var r = Math.Pow(Abs(src), pwr);
    return new ComplexNumber(r * Math.Cos(angle), r * Math.Sin(angle));
  }
  public static ComplexNumber[] NRoot(ComplexNumber src, int pwr)
  {
    List<ComplexNumber> res = new();
    var angle = Angle(src);
    var r = Math.Pow(Abs(src), 1 / pwr);

    for (var k = 0; k < pwr; k++) {
      var tempAngle = (angle + 2 * Math.PI * k) / pwr;
      res.Add(new ComplexNumber(r * Math.Cos(tempAngle), r * Math.Sin(tempAngle)));
    }
    return res.ToArray();
  }
  public static double Abs(ComplexNumber src)
  {
    return Math.Sqrt(src.Real * src.Real + src.Img * src.Img);
  }
  public static double Angle(ComplexNumber src)
  {
    var angle =  Math.Atan(src.Img / src.Real);
    if (src.Real < 0) {
      angle += Math.PI;
    }
    return angle;
  }

  public override string ToString()
  {
    if (Img == 0) {
      return Real.ToString();
    }
    var sign = Img >= 0 ? "+" : "";
    if (Real == 0) {
      if (Math.Abs(Img) == 1) {
        return Img >= 0 ? $"{Img}i" : $"-{Img}i";
      }
    }
    return Math.Abs(Img) == 1 ? $"{Real}{sign}i" : $"{Real}{sign}{Img}i";
  }
}
