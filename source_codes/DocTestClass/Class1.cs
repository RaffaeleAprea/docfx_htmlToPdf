using System;
using System.Collections.Generic;




namespace DocTestClass
{
    /// <summary>
    /// Main Class lorem ipsum dixit
    /// Lorem ipsum dolor sit amet, consectetur adipisci elit, sed <br/>
    /// do eiusmod tempor incidunt ut<br/> labore et dolore magna aliqua
    /// </summary>
    public class TestClassA
    {
        /// <summary>
        /// Public method ipse dicit
        /// </summary>
        /// <example>
        /// <code lang="cs">
        /// TestClass foo = new TestClass("bar",12301230, dObj)<br/>
        /// foo.PublicMethod
        /// </code>
        /// </example>
        public void PublicMethod()
        {

        }
        /// <summary>
        /// Constructor Method
        /// </summary>
        /// <param name="param1">name of the caller</param>
        /// <param name="param2">ID of the caller</param>
        /// <param name="dictConfig"> Configuration metadata</param>

        public TestClassA(string param1, int param2, Dictionary<string, object> dictConfig)
        {

        }

        /// <summary>
        /// Returns the ID of the instance
        /// </summary>
        string param { get; set; }

        /// <summary>
        /// Number of instanced that has been created out of this class
        /// </summary>
        static int numOfInstances {get;}
    }

    /// <summary>
    /// Support Class lorem ipsum dixit<br/>
    /// Lorem ipsum dolor sit amet, consectetur adipisci elit, sed <br/>
    /// do eiusmod tempor incidunt ut<br/> labore et dolore magna aliqua
    ///Lorem ipsum dolor sit amet, consectetur adipisci elit, sed <br/>
    ///do eiusmod tempor incidunt ut<br/> labore et dolore magna aliqua
    ///</summary>
    public class TestClassB
    {
        /// <summary>
        /// Public method ipse dicit
        /// </summary>
        /// <example>
        /// Example of usage<br/>
        /// Lorem ipsum dolor sit amet, consectetur adipisci elit, sed <br/>
        /// do eiusmod tempor incidunt ut<br/> labore et dolore magna aliqua
        /// <code>
        /// 
        /// TestClass foo = new TestClass("bar",12301230, dObj)<br/>
        /// foo.PublicMethod
        /// 
        /// </code>
        /// </example>
        public void PublicMethod()
        {

        }
        /// <summary>
        /// Constructor Method
        /// </summary>
        /// <param name="dictConfig"> Configuration metadata</param>
        /// <param name="param1">name of the caller</param>
        /// <param name="param2">ID of the caller</param>
        public TestClassB(string param1, int param2, Dictionary<string, object> dictConfig)
        {

        }

        /// <summary>
        /// Returns the ID of the instance<br/> Lorem ipsum dolor sit amet, consectetur adipisci elit, sed do eiusmod tempor incidunt ut labore et dolore magna aliqua
        /// </summary>
        string param { get; set; }

        /// <summary>
        /// Number of instanced that has been created out of this class<br/> Lorem ipsum dolor sit amet, consectetur adipisci elit, sed do eiusmod tempor incidunt ut labore et dolore magna aliqua
        /// </summary>
        static int numOfInstances { get; }
    }
}
