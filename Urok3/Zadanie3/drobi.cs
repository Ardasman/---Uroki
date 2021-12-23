class Drobi
        {
            public int chesl;
            public int znam;

            public Drobi(int hes, int nam)
            {
                this.chesl = hes;
                if (nam  == 0)   // проверка знаменателя на ноль
                    throw new ArgumentException("Знаменатель не может быть равен 0"); 
                else  if (nam<0) // сменя знака числителя и знаменателя при отрицательном знаменатели
                {
                    this.chesl=-this.chesl;
                    this.znam = -nam;
                 }
                 else
                 this.znam = nam;
            }

            public Drobi Sum(Drobi a)
            {
                Drobi result;
               
                result = new((this.chesl * a.znam + a.chesl* this.znam), this.znam * a.znam);

                return result;
            }

            public Drobi Diff(Drobi a)
            {
                Drobi result;
               
                result = new((this.chesl * a.znam - a.chesl* this.znam), this.znam * a.znam);

                return result;
            }

            public Drobi Mult(Drobi a)
            {
                Drobi result;
               
                result = new(this.chesl * a.chesl, this.znam * a.znam);

                return result;
            }

            public Drobi Del(Drobi a)
            {
                Drobi result;
               
                result = new(this.chesl * a.znam, this.znam * a.chesl);

                return result;
            }

            public override string ToString()
            {
                string s;
                s = $"{chesl}/{znam}";

                return s;
            }

            


        }
            
