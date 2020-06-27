using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using DocTestClass;



namespace Second_Doc_TestClass_A
{
    /// <summary>
    /// Lorem ipsum dolor sit amet, consectetur adipisci elit, sed <br/>
    /// do eiusmod tempor incidunt ut<br/> labore et dolore magna aliqua
    /// </summary>
    public class TestClass2
    {
        /// <summary>
        /// number of instances
        /// </summary>
        private bool instanceCreated = false;
        /// <summary>
        /// The costructor is private<br/> labore et dolore magna aliqua
        /// </summary>
        private TestClass2()
        {

        }

        /// <summary>
        /// Returns only an instance of this class and of TestClassA inside a dictionary. If an instance has already been created then return value is null 
        /// </summary>
        /// <example>
        /// Example code of the usage of <c>getInstance()</c><br/>
        /// Lorem ipsum dolor sit amet, consectetur adipisci elit, sed do eiusmod tempor incidunt ut<br/> labore et dolore magna aliqua
        /// <code lang ="cs">
        /// var objs = TestClass2.getInstance();
        /// TestClass2 obj = objs["TestClass2"] ;
        /// TestClassA objA = objs["TestClassA"];
        /// </code>
        /// </example>
        /// <returns>
        /// Returns a Dictionary
        /// </returns>
        public Dictionary<string,object> getInstance()
        {
            Dictionary<string, object> returnValues = new Dictionary<string, object>();
            Dictionary<string, object> config = new Dictionary<string, object>();
            if (!instanceCreated)
                returnValues.Add("TestClass2", new TestClass2());
            else

            returnValues.Add("TestClassA", new TestClassA("TESTCLASS2",123,config));
            
            return returnValues;
        }
        /// <summary>
        /// Destructor
        /// </summary>
        ~TestClass2()
        {
            instanceCreated = false;
        }
    }
    /// <summary>
    /// Lorem ipsum dolor sit amet, consectetur adipisci elit, sed <br/>
    /// do eiusmod tempor incidunt ut<br/> labore et dolore magna aliqua
    /// </summary>
    public class TestClass3
    {
        /// <summary>
        /// number of instances
        /// </summary>
        private bool instanceCreated = false;
        /// <summary>
        /// The costructor is private
        /// </summary>
        private TestClass3()
        {

        }

        /// <summary>
        /// Returns only an instance of this class and of <c>TestClassA</c>inside a dictionary
        /// </summary>
        /// <example>
        /// Example of usage
        /// <code lang="cs">
        /// 
        /// var objs = TestClass2.getInstance();
        /// TestClass2 obj = objs["TestClass2"] ;
        /// TestClassA objA = objs["TestClassA"];
        /// </code>
        /// </example>
        /// <returns>Returns a dictionary containing two objects</returns>
        public Dictionary<string, object> getInstance()
        {
            Dictionary<string, object> returnValues = new Dictionary<string, object>();
            Dictionary<string, object> config = new Dictionary<string, object>();
            if (!instanceCreated)
                returnValues.Add("TestClass2", new TestClass3());
            returnValues.Add("TestClassA", new TestClassA("TESTCLASSA2", 123, config));

            return returnValues;
        }


        /// <summary>
        /// Property A  <br/>Lorem ipsum dolor sit amet, consectetur adipisci elit, sed do eiusmod tempor incidunt ut labore et dolore magna aliqua
        /// 
        /// </summary>
        /// <value>
        /// bla bla bla 
        /// </value>
        public string Property_A { get; set; }

        /// <summary>
        /// Property B (read-only)  Lorem ipsum dolor sit amet, consectetur adipisci elit, sed do eiusmod tempor incidunt ut labore et dolore magna aliqua
        /// 
        /// </summary>
        public string Property_B { get; }


        /// <summary>
        /// Destructor
        /// </summary>
        /// <value>
        /// bla bla bla 
        /// </value>
        ~TestClass3()
        {
            instanceCreated = false;
        }
    }
}
