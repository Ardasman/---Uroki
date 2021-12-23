struct Complex
{
public double numA, numB;

public Complex (double re, double im)
{
    this.numA = re;
    this.numB = im;
}
  // Сумма двух комплексных чисел
public Complex Sum(Complex z)
{
Complex result;
result = new(this.numA+z.numA, this.numB+z.numB);

return result;
}

public override string ToString() // Переопределяем метод ToString
    {
        string s;
        if (numB<0) s = $"{numA} - {-numB}i";
        else s = $"{numA} + {numB}i";
        
        return s;
    }

public void ShowSum()
{
    System.Console.WriteLine($"Сумма двух комплексных чисел: "+ToString());
    
}

// Разница двух комплексных чисел
public Complex Diff(Complex z)
{
Complex result;
result = new(this.numA-z.numA, this.numB-z.numB);

return result;
}

public void ShowDiff()
{
    System.Console.WriteLine($"Разница двух комплексных чисел: "+ToString());
    
}
// Произведение двух комплексных чисел

public Complex Mult(Complex z)
{
Complex result;
result = new(this.numA*z.numA-this.numB*z.numB, this.numB*z.numA+this.numA*z.numB);

return result;
}

public void ShowMult()
{
    System.Console.WriteLine($"Произведение двух комплексных чисел: "+ToString());
    
}

}
