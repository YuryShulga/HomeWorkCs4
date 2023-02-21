using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCs4
{
    internal class Money
    {
        private int rubl;
        private int penny;
        public int Rubl {
            get {
                return rubl;
            }
            set {
                if (value >= 0) {
                    rubl = value;
                }
                else rubl = 0;
            }
        }
        public int Penny
        {
            get {
                return penny;
            }
            set {
                if (value >= 0) {
                    penny = value;
                }
                else penny = 0;
            }
        }
        //сумма в копейках
        public int Total {
            get {
                return Rubl * 100 + Penny;
            }
        }
        public Money(int _rubl, int _penny) {
            Rubl = _rubl;
            if (_penny > 99) {
                penny = _penny % 100;
                rubl += (_penny - _penny % 100) / 100;
            }
            else {
                Penny = _penny;
            }
        }
        public Money(int _rubl) : this(_rubl, 0) { }
        public Money() : this(0, 0) { }
        public override string ToString() {
            return $"{Rubl} рублей, {Penny} копеек";
        }
        public Money(Money m) : this(m.Rubl, m.Penny) { }
        //сложение денежных сумм
        public Money AddMoney(Money m1) {
            return new Money(Rubl + m1.Rubl, Penny + m1.Penny);
        }
        public static Money operator +(Money m1, Money m2) {
            return m1.AddMoney(m2);
        }
        //вычитание денежной суммы
        public Money SubMoney(Money m1) {
            return new Money(0, Total-(m1.Total) ); ;
        }
        public static Money operator -(Money m1, Money m2) { 
            return m1.SubMoney(m2);
        }
        //деление суммы на целое число
        public Money DivMoney(int num) {
            return new Money(0,(int)Total/num);
        }
        public static Money operator /(Money m1, int num) {
            return m1.DivMoney(num);
        }
        //умножение суммы на целое число
        public Money MultMoney(int num) {
            return new Money(0, Total * num);
        }
        public static Money operator *(Money m1, int num){
            return m1.MultMoney(num);
        }
        //инкремент суммы (+1 копейка)
        public Money IncrementMoney() { 
            Money temp=this.AddMoney(new Money(0,1));
            Rubl=temp.Rubl;
            Penny=temp.Penny;
            return this;
        }
        public static Money operator ++(Money m1) {
              return m1.IncrementMoney();
        }
        //декремент суммы (-1 копейка)
        public Money DecrementMoney() {
            Money temp = this.SubMoney(new Money(0, 1));
            Rubl = temp.Rubl;
            Penny = temp.Penny;
            return this;
        }
        public static Money operator --(Money m1){
            return m1.DecrementMoney();
        }
        //реализация оператора >
        public static bool operator >(Money m1, Money m2) {
            return (m1.Total) > (m2.Total);
        }
        //реализация оператора <
        public static bool operator <(Money m1, Money m2){
            return (m1.Total) < (m2.Total);
        }
        // override Equals()
        public override bool Equals(object obj){
            if (obj is Money m1) {
                return Total == m1.Total;
            }
            return false;
        }
        // override GetHashCode()
        public override int GetHashCode(){
            return ToString().GetHashCode();
        }
        //переопределение оператора == 
        public static bool operator ==(Money m1, Money m2) { 
            return m1.Equals(m2);
        }
        //переопределение оператора !=
        public static bool operator !=(Money m1, Money m2){
            return !m1.Equals(m2);
        }
    }
}
