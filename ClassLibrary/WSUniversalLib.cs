using System;

namespace ClassLibrary
{
    public class Calc
    {

        float[] product_type = new float[] { 1.1F, 2.5F, 8.43F };
        float[] waste_material_type = new float[] { 0.1F, 0.95F, 0.28F, 0.55F, 0.34F };


        public int GetQuantityForProduct(int count, float width, float length, int product_type, int material_type)
        {
            if (width <= 0 || length <= 0)
            {
                throw new ArgumentOutOfRangeException("Длина и ширина должны быть больше 0");
            }
            if (product_type <= this.product_type.Length && product_type >= 1)
            {
                if (material_type <= waste_material_type.Length && material_type >= 1)
                {
                    float result = ((width * length) * this.product_type[product_type - 1]) * Convert.ToSingle(count);
                    result = result + result * (waste_material_type[material_type - 1] + 1);
                    return Convert.ToInt32(Math.Ceiling(result));
                }
                else
                {
                    return -1;
                }

            }
            else
            {
                return -1;
            }

        }
    }
}
