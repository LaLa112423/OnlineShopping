using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Amqp;
using OnlineShopping.IDal;
namespace OnlineShopping.Dal
{
    public class test : Itest
    {
        //简单工厂模式
        //只能调用一个接口获取一个方法如果请求不同的话只能再换另一种方法
        public string drink(string str)
        {
            if (str == "美年达")
            {
                return mei();
            } else if (str == "雪碧")
            {
                return xue();
            }
            else
            {
                return "暂无此选项";
            }
        }
        public string mei()
        {
            return "这里是美年达";
        }


        public string xue()
        {
            return "这里是雪碧";
        }
        //抽象工厂模式
        //主要在于如何调用一个接口可以获取同一种车辆的不同型号
        public void fruits()
        {
            caomei();
            pingguo();
        }
        public void vegetable()
        {
            qiezi();
            doujiao();
        }
        public string caomei()
        {
            return "这里是草莓";
        }
        public string pingguo()
        {
            return "这里是苹果";
        }
        public string qiezi()
        {
            return "这里是茄子";
        }
        public string doujiao()
        {
            return "这里是豆角";
        }
        //建造者类
        //重点在于如何组件这个东西
        public void jiu()
        {
            pi();
            xian();
        }
        public void zhu()
        {
            pi1();
            xian1();
        }
        public string pi()
        {
            return "饺子皮";
        }

        public string xian()
        {
            return "韭菜鸡蛋";
        }
        public string pi1()
        {
            return "饺子皮";
        }

        public string xian1()
        {
            return "猪肉香菇";
        }
        //策略模式
        //如何使用一个接口的时候可以调用不同的对象减少判断
        /// <summary>
        /// 环境角色--相当于Context类型
        /// </summary>
        public sealed class SalaryContext
        {
            public ISalaryStrategy SalaryStrategy { get; set; }

            public SalaryContext(ISalaryStrategy strategy)
            {
                SalaryStrategy = strategy;
            }

            public void GetSalary(double income)
            {
                SalaryStrategy.CalculateSalary(income);
            }
        }

        /// <summary>
        /// 抽象策略角色--相当于Strategy类型
        /// </summary>
        public interface ISalaryStrategy
        {
            //工资计算
            void CalculateSalary(double income);
        }

        /// <summary>
        /// 程序员的工资--相当于具体策略角色ConcreteStrategyA
        /// </summary>
        public sealed class ProgrammerSalary : ISalaryStrategy
        {
            public void CalculateSalary(double income)
            {
                Console.WriteLine("程序员的工资是：基本工资(" + income + ")底薪(" + 8000 + ")+加班费+项目奖金（10%）");
            }
        }

        /// <summary>
        /// 普通员工的工资--相当于具体策略角色ConcreteStrategyB
        /// </summary>
        public sealed class NormalPeopleSalary : ISalaryStrategy
        {
            public void CalculateSalary(double income)
            {
                Console.WriteLine("普通员工的工资是：基本工资(" + income + ")底薪(3000)+加班费");
            }
        }

        /// <summary>
        /// CEO的工资--相当于具体策略角色ConcreteStrategyC
        /// </summary>
        public sealed class CEOSalary : ISalaryStrategy
        {
            public void CalculateSalary(double income)
            {
                Console.WriteLine("CEO的工资是：基本工资(" + income + ")底薪(20000)+项目奖金(20%)+公司股票");
            }
        }

        static void Main(string[] args)
        {
            #region 策略模式
            //普通员工的工资
            SalaryContext context = new SalaryContext(new NormalPeopleSalary());
            context.GetSalary(3000);

            //CEO的工资
            context.SalaryStrategy = new CEOSalary();
            context.GetSalary(6000);

            Console.Read();
            #endregion
        }
        //单列模式
        public class SingletonSecond
        {
            // // 定义一个静态变量来保存类的实例
            private static SingletonSecond _SingletonSecond = null;
            // 定义私有构造函数，使外界不能创建该类实例
            static SingletonSecond()
            {

                _SingletonSecond = new SingletonSecond();
            }
            //定义公有方法提供一个全局访问点,同时你也可以定义公有属性来提供全局访问点
            public static SingletonSecond CreateInstance()
            {
                return _SingletonSecond;
            }
        }
    }
}
