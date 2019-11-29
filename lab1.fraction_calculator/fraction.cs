using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab1.calculator;
namespace lab1.calculator
{
    class fractionC
    {
        private int numerator = 0, denominator = 0;
        public string option="Null";

        public fractionC(int t1, int t3)
        {
            numerator = t1;
            denominator = t3;
        }

        public void setNum (int t1, int t2)
        {
            numerator = t1;
            denominator = t2;
        }

        public int getInt
        {
            get
            {
                if(denominator!=0)
                    return (numerator / denominator);
                else
                    return 0;
            }
        }
        public int getNum
        {
            get
            {
                if (denominator != 0)
                {
                    if ((numerator / denominator) == 0 && numerator < 0)
                        return ((numerator % denominator));
                    else
                        return Math.Abs(numerator % denominator);
                }
                else
                    return 0;
            }
        }
        public int getDen
        {
            get { return (denominator); }
        }
        
        public void optimization()
        {
            int temp;
            if (denominator > 100)
                temp = 100;
            else
                temp = denominator;
            for (int i = temp; i > 0; i--)
                if (denominator % i == 0 && numerator % i == 0)
                {
                    denominator /= i;
                    numerator /= i;
                }
        }
            
        public void sum(int num, int den)
        {
            numerator = numerator * den + num * denominator;
            denominator*= den;
        }
        public void compose(int num, int den)
        {
            numerator *= num;
            denominator *= den;
        }
        public void reverce()
        {
            int temp = numerator;
            numerator = denominator;
            denominator = temp;
        }

        public void fractionCompile(int num, int den)
        {
            if (den != 0 && num!=0)
            {
                switch (option)
                {
                    case "Null":
                        {
                            //msg no activity
                            about info = new about("To function choosen.");
                            info.Show();
                            break;
                        }
                    case "buttonPlus":
                        {
                            sum(num, den);
                            break;
                        }
                    case "buttonMinus":
                        {
                            sum(-num, den);
                            break;
                        }
                    case "buttonCompose":
                        {
                            compose(num, den);
                            break;
                        }
                    case "buttonDivide":
                        {
                            compose(den, num);
                            break;
                        }
                    case "buttonPOW":
                        {
                            compose(numerator, denominator);
                            break;
                        }
                    case "buttonReverce":
                        {
                            if (denominator != 0)
                                reverce();
                            else
                                setNum(0, 1);
                            break;
                        }
                }
                optimization();
            }
        }
    }
}
