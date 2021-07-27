using System;

namespace Chapter_07
{
    class Configuration
    {
        private readonly int min;
        private readonly int max;

        public Configuration(int v1, int v2)
        {
            min = v1;
            max = v2;
            // 읽기전용필드는 생성자에서만 초기화가능s
        }

        public void ChangeMax(int newMax)
        {
            // max = newMax; 생성자가 아닌 곳에서 변수값 수정시 오류 발생
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Configuration c = new Configuration(100, 10);
        }
    }
}
