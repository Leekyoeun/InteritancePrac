class Animal 
{
    public int Age { get; set; }
    public string Color { get; set; }
    public Animal() { this.Age = 0; }
    public void Eat() { Console.WriteLine("�ȳ�"); }
    public void Sleep() { Console.WriteLine("����"); }
}