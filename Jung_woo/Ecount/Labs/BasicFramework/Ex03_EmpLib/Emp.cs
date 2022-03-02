using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_EmpLib
{
    public class Emp
    {
        private int empno;
        private string ename;
        private int sal;

        public Emp() { }
        public Emp(int empno, string ename, int sal)
        {
            this.empno = empno;
            this.ename = ename;
            this.sal = sal;
        }
        public int Empno // -> 프로퍼티라 부른다.
        {
            get { return empno; }
            set { empno = value; }
        }
        public string Ename
        {
            get { return ename; }
            set { ename = value; }
        }
        public int Sal
        {
            get { return sal; }
            set { sal = value; }
        }

        public void EmpPrint()
        {
            Console.WriteLine("{0} - {1} - {2}", this.empno, this.ename, this.sal);
        }
    }
}
