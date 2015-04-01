//Problem 1. Student class• Define a class  Student , which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
//• Override the standard methods, inherited by  System.Object :  Equals() ,  ToString() ,  GetHashCode()  and operators  ==  and  != .
//Problem 2. IClonable• Add implementations of the  ICloneable  interface. The  Clone()  method should deeply copy all object's fields into a new object of type  Student .
//Problem 3. IComparable• Implement the  IComparable<Student>  interface to compare students by names (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).

using System;

namespace Problem01_03
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            Student ivanPetkov = new Student("Ivan", "Petkov", "Petkov", 8312014578, "12 Antim I,Plovdiv", "+3599988884", "ipp@abv.bg", 2,
                Specialties.Surgery, Universities.MedicalUniversity, Faculties.Medical);

            Student ivanPetkov1 = new Student("Ivan", "Petkov", "Petkov", 8202014578, "12 Antim I,Plovdiv", "+3599988884", "ipp@abv.bg", 2,
                Specialties.Dermatology, Universities.EconomicUniversity, Faculties.Medical);

            Console.WriteLine(ivanPetkov);
            Console.WriteLine();
            Console.WriteLine(ivanPetkov1);
            Console.WriteLine();
            Console.WriteLine(ivanPetkov.Equals(ivanPetkov1));
            Console.WriteLine(ivanPetkov.GetHashCode());
            Console.WriteLine(ivanPetkov1.GetHashCode());

            Student niki = new Student("Ivan", "Petkov", "Petkov", 9012014878, "12 Antim I,Plovdiv", "+359998884", "ipp@abv.bg", 2,
                Specialties.Dermatology, Universities.MedicalUniversity, Faculties.Physician);
            Console.WriteLine(niki.GetHashCode());
            Console.WriteLine(ivanPetkov1 == niki);
            Console.WriteLine(ivanPetkov1 != niki);
            Console.WriteLine();
            var nikiClone = niki.Clone();
            Console.WriteLine(nikiClone);
            Console.WriteLine(ivanPetkov.CompareTo(ivanPetkov1));
        }
    }
}
