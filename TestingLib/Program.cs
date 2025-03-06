using ClassLibrary;
namespace TestingLib

{
    internal class Program
    {
        static void Main()
        {
            int count;
            float width;
            float length;
            int product_type;
            int material_type;
            try
            {
                Console.WriteLine("Введите длину продукции: ");
                length = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Введите ширину продукции: ");
                width = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Введите кол-во продукции: ");
                count = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите тип продукции: ");
                product_type = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите материал продукции: ");
                material_type = Convert.ToInt32(Console.ReadLine());
                Calc calc = new Calc();
                int res = calc.GetQuantityForProduct(count, width, length, product_type, material_type);
                Console.WriteLine(res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }
    }
}
