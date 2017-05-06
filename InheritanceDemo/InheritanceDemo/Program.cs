using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InheritanceDemo
{
    class Member
    {
        //Protected and public items can be seen by child classes.
        protected int annualFee;
        //Private members are restricted to this class.
        private string name;
        private int memberID;
        private int memberSince;

        public Member()
        {
            WriteLine("Parent Contructor with no parameter");
        }

        public Member(string pName, int pMemberID, int pMemberSince)
        {
            WriteLine("Parent Constructor with 3 parameters");

            name = pName;
            memberID = pMemberID;
            memberSince = pMemberSince;
        }

        public override string ToString()
        {
            return "\nName: " + name
                + "\nMember ID: " + memberID
                + "\nMember Since: " + memberSince
                + "\nTotal Annual Fee: " + annualFee;
        }

        //Virtual indicates that this method may be overridden in derived classes.
        public virtual void CalculateAnnualFee()
        {
            annualFee = 0;
        }
    }

    class NormalMember : Member
    {
        public NormalMember()
        {
            //The parent constructor with no parameters will be called first.
            WriteLine("Child Constructor with no parameter");
        }

        public NormalMember(string remarks, string name, int memberID, int memberSince)
            : base (name, memberID, memberSince)
        {
            //Parameters 2-4 will be passed to the parent constructor, then this constructor
            //will execute.
            WriteLine("Child Constructor with 4 parameters");
            WriteLine("Remarks = {0}", remarks);
        }

        //Override indicates that this method overrides the parent method of the same name.
        public override void CalculateAnnualFee()
        {
            annualFee = 100 + 12 * 30;
        }
    }

    class VIPMember : Member
    {
        public VIPMember(string name, int memberID, int memberSince)
            : base (name, memberID, memberSince)
        {
            WriteLine("Child Constructor with 3 parameters");
        }

        public override void CalculateAnnualFee()
        {
            annualFee = 1200;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //NormalMember mem1 = new NormalMember("Special Rate", "James", 1, 2010);
            //VIPMember mem2 = new VIPMember("Andy", 2, 2011);

            //mem1.CalculateAnnualFee();
            //mem2.CalculateAnnualFee();

            //WriteLine(mem1.ToString());
            //WriteLine(mem2.ToString());

            //Since this array is based on the parent class, it can contain any child class.
            Member[] clubMembers = new Member[5];

            //The runtime type of 0-2 is NormalMember, the runtime type of 3-4 is VIPMember.
            //The declared type of all 5 is Member.
            clubMembers[0] = new NormalMember("Special Rate", "James", 1, 2010);
            clubMembers[1] = new NormalMember("Normal Rate", "Andy", 2, 2011);
            clubMembers[2] = new NormalMember("Normal Rate", "Bill", 3, 2011);
            clubMembers[3] = new VIPMember("Carol", 4, 2012);
            clubMembers[4] = new VIPMember("Evelyn", 5, 2012);

            foreach (Member m in clubMembers)
            {
                //We can't call this method unless it exists in the parent class.
                m.CalculateAnnualFee();
                WriteLine(m.ToString());

                //The runtime type can be determined at runtime.
                if (m.GetType() == typeof(VIPMember))
                    WriteLine("VIP");
                else
                    WriteLine("Normal");
            }
            ReadKey();
        }
    }
}
