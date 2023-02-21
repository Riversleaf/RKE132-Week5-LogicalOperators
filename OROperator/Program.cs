//Math >= 90 OR Chemistry >= 90

//Math && Chemistry || Math && Biology || Chemistry && Biology

int math, biology, chemistry;

Console.WriteLine("Enter Your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter Your Biology result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter Your Chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());

if((math >= 90 && chemistry >= 90) || (math >= 90 && biology >= 90) || (chemistry >= 90 && biology >= 90))
{
    Console.WriteLine("Congratulations! You got accepted!");
}
else
{
    Console.WriteLine("Your application cannot be approved.");
}