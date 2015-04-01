using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem01_03
{
    public class Student:ICloneable,IComparable<Student>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public long SSN { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public string EMail { get; set; }
        public int Course { get; set; }
        public Specialties Specialty { get; set; }
        public Universities University { get; set; }
        public Faculties Faculty { get; set; }

        public Student(string firstName, string middleName, string lastName, long ssn, string address, string mobilePhone, string eMail, int course,
            Specialties specialty, Universities university, Faculties faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.EMail = eMail;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }
        
        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if (student == null)
            {
                return false;
            }
            if (
                !Object.Equals(this.FirstName, student.FirstName) ||
                !Object.Equals(this.MiddleName, student.MiddleName) ||
                !Object.Equals(this.LastName, student.LastName) ||
                !Object.Equals(this.SSN, student.SSN) ||
                !Object.Equals(this.Address, student.Address) ||
                !Object.Equals(this.MobilePhone, student.MobilePhone) ||
                !Object.Equals(this.EMail, student.EMail) ||
                !Object.Equals(this.Course, student.Course) ||
                !Object.Equals(this.Specialty, student.Specialty) ||
                !Object.Equals(this.University, student.University) ||
                !Object.Equals(this.Faculty, student.Faculty)
                )
            {
                return false;
            }
            return true;
        }
        public override int GetHashCode()
        {
            return MobilePhone.GetHashCode() ^ SSN.GetHashCode();
        }
        public static bool operator ==(Student student1,Student student2)
        {
            return Student.Equals(student1, student2);
        }
        public static bool operator !=(Student student1,Student student2)
        {
            return !(Student.Equals(student1, student2));
        }
        public override string ToString()
        {
            return string.Format(
                "{0} {1} {2}\nSocial Security Number:{3}\nAddres:{4}\nMobile:{5}\nE-mail:{6}\nCourse:{7}\n{8}, {9}, {10}",
                this.FirstName, this.MiddleName, this.LastName,
                this.SSN,
                this.Address,
                this.MobilePhone,
                this.EMail,
                this.Course,
                this.Specialty, this.University, this.Faculty);
        }

        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName,
                this.SSN,
                this.Address,
                this.MobilePhone,
                this.EMail,
                this.Course,
                this.Specialty, this.University, this.Faculty);
        }

        public int CompareTo(Student other)
        {
            if (!this.FirstName.Equals(other.FirstName))
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
            if (!this.MiddleName.Equals(other.MiddleName))
            {
                return this.MiddleName.CompareTo(other.MiddleName);
            }
            if (!this.LastName.Equals(other.LastName))
            {
                return this.LastName.CompareTo(other.LastName);
            }
            if (!this.SSN.Equals(other.SSN))
            {
                return this.SSN.CompareTo(other.SSN);
            }
            return 0;
        }
    }
}
