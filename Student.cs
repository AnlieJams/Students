using System;

public class Student
{
    private string lastName;
    private string patronymic;
    private DateTime dateOfBirth;
    private Address homeAddress;
    private string phoneNumber;
    private int[] homeworkGrades;
    private int[] courseworkGrades;
    private int[] examGrades;

    public Student(string lastName, string patronymic, DateTime dateOfBirth, Address homeAddress, string phoneNumber)
    {
        this.lastName = lastName;
        this.patronymic = patronymic;
        this.dateOfBirth = dateOfBirth;
        this.homeAddress = homeAddress;
        this.phoneNumber = phoneNumber;
        this.homeworkGrades = new int[0];
        this.courseworkGrades = new int[0];
        this.examGrades = new int[0];
    }

    public Student(string lastName, string patronymic, DateTime dateOfBirth, Address homeAddress, string phoneNumber,
        int[] homeworkGrades, int[] courseworkGrades, int[] examGrades)
    {
        this.lastName = lastName;
        this.patronymic = patronymic;
        this.dateOfBirth = dateOfBirth;
        this.homeAddress = homeAddress;
        this.phoneNumber = phoneNumber;
        this.homeworkGrades = homeworkGrades;
        this.courseworkGrades = courseworkGrades;
        this.examGrades = examGrades;
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string Patronymic
    {
        get { return patronymic; }
        set { patronymic = value; }
    }

    public DateTime DateOfBirth
    {
        get { return dateOfBirth; }
        set { dateOfBirth = value; }
    }

    public Address HomeAddress
    {
        get { return homeAddress; }
        set { homeAddress = value; }
    }

    public string PhoneNumber
    {
        get { return phoneNumber; }
        set { phoneNumber = value; }
    }

    public int[] HomeworkGrades
    {
        get { return homeworkGrades; }
        set { homeworkGrades = value; }
    }

    public int[] CourseworkGrades
    {
        get { return courseworkGrades; }
        set { courseworkGrades = value; }
    }

    public int[] ExamGrades
    {
        get { return examGrades; }
        set { examGrades = value; }
    }

    public void DisplayStudentInfo()
    {
        Console.WriteLine("Информация о студенте:");
        Console.WriteLine("Фамилия: " + lastName);
        Console.WriteLine("Отчество: " + patronymic);
        Console.WriteLine("Дата рождения: " + dateOfBirth.ToShortDateString());
        Console.WriteLine("Домашний адрес: " + homeAddress.ToString());
        Console.WriteLine("Номер телефона: " + phoneNumber);
        Console.WriteLine("Оценки за домашние задания: " + string.Join(", ", homeworkGrades));
        Console.WriteLine("Оценки за работу в классе: " + string.Join(", ", courseworkGrades));
        Console.WriteLine("Оценки за экзамены: " + string.Join(", ", examGrades));
    }
}

public class Address
{
    private string street;
    private string city;
    private string postalCode;

    public Address(string street, string city, string postalCode)
    {
        this.street = street;
        this.city = city;
        this.postalCode = postalCode;
    }

    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string PostalCode
    {
        get { return postalCode; }
        set { postalCode = value; }
    }

    public override string ToString()
    {
        return street + ", " + city + ", " + postalCode;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("Улица Пушкинская", "Город", "65125");

        Student student = new Student("Уайт", "Уолтер", new DateTime(2000, 1, 1), address, "223-777-1337");
        student.HomeworkGrades = new int[] { 85, 90, 78 };
        student.CourseworkGrades = new int[] { 92, 88, 95 };
        student.ExamGrades = new int[] { 80, 85, 90 };

        student.DisplayStudentInfo();

        Console.ReadLine();
    }
}
