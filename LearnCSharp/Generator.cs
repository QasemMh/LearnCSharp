using System;
using System.Collections.Generic;

namespace LearnCSharp
{



    // <include file="Generator.xml" path='doc/members[@name="generator"]/Generator/*'/>


    /// <summary>
    /// The main Generator class
    /// </summary>
    /// <remarks>
    /// This class generate random fake data
    /// </remarks>
    public static class Generator
    {

        /// <value> This is main Id value</value>
        public const int Id = 0;

        /// <summary>
        /// this method print data by processing <paramref name="id"/> <paramref name="fName"/> <paramref name="date"/>
        /// <list type="bullet">
        /// <item>
        /// <term>id</term>
        /// <description>employee unique number</description>
        /// </item>  
        /// <item>
        /// <term>f name</term>
        /// <description>employee First Name</description>
        /// </item>    
        /// <item>
        /// <term>date</term>
        /// <description>employee hire date</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id">this is id</param>
        /// <param name="fName">this is first name</param>
        /// <param name="date">this is hire date with format dd/MM/yyyy</param>
        /// <example>
        /// <code>
        /// Generator.Print(1,"Mark", DateTime.Now.Date);
        /// </code>
        /// </example>
        /// <remarks>remarks here</remarks>
        /// <returns>
        /// void
        /// </returns>
        /// <exception cref="System.ArgumentNullException">Desc the exception Here</exception>
        /// See <see cref="Report.GetReport(List{Employee}, string, Report.IsFitSales)">Text here</see>
        public static void Print(int id, string fName, DateTime? date)
        {

        }

    }





}
