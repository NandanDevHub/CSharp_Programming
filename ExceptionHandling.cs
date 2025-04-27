namespace CSharp_Programming
{
    internal class ExceptionHandling
    {
        public void ExHandling(int num1, int num2)
        {
            try
            {
                var c = num1 / num2; // This will cause a DivideByZeroException
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("This block always executes.");
            }
        }

        public void ExFormatHandling()
        {
            try
            {
                Console.WriteLine("Enter two numbers: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid format.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("This block always executes.");
            }
        }
    }
}
