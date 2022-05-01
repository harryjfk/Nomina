using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using NCalc;

namespace Nomina.Opciones
{
 
    ////public class FuncData
    ////{
    ////    public FuncData(string nameformula, string valueformula)
    ////    {
    ////        Name = nameformula;
    ////        Str = valueformula;
    ////    }

    ////    public String Name { get; set; }
    ////    public String Str { get; set; }
    ////    //public bool IsRounded()
    ////    //{
        
    ////    //}

    ////    public void GetAllFunctions(List<FuncData> data)
    ////    {
    ////        int r = 0;
    ////      var s =  parser.GetFuncReal(Str);
    ////      foreach (FuncData w in s)
    ////          if (data.IndexOf(w) == -1)
    ////          {
    ////              data.Add(w);
    ////              w.GetAllFunctions(data);
    ////          }

    ////    }

    ////    public MathParser parser { get; set; }
    ////    public bool HasChild(String name)
    ////    {
    ////        var s = new List<FuncData>();
    ////        GetAllFunctions(s);
    ////        int r;

    ////        if (parser.FindInFuncData(s, name, out r))
    ////            return true;
            

    ////        return false;
    ////    }
    ////}

    //public class MathParser
    //{
    //    private Expression mathreal;
    //    private List<DBData> data = new List<DBData>();
    //    private void GetVarsFromString()
    //    {
    //        data.Clear();
    //        var w = String.Split(Convert.ToChar(" "));
    //        foreach (string s1 in w)
    //            if (s1 != "" && s1.IndexOf("dbo") != -1)
    //                data.Add(new DBData(s1, this));
    //        //FoundFunctions= GetFuncReal(String);
    //    }

    

  
    //    public object Evaluate()
    //    {
    //        var s = "";
    //        if(CheckForErrors(out s))
    //        {
                
    //            if (IsIterative())
    //            {
    //                var w = new List<string>();
    //                var t = data[0].GetColumn().Table.Rows.Count;
    //                   //aqui hay quer revisar cuando es de difierentes tablar hacer despues

    //                for (int i = 0; i < t; i++)
    //                    w.Add(String);
    //                foreach (DBData dbData in data)
    //                {
                     
    //                var q = dbData.GetValuesFromVar();
    //                    for (int i = 0; i < w.Count; i++)
    //                        w[i] = w[i].Replace(dbData.Field, q[i].ToString());
    //                }
    //                for (int i = 0; i < t; i++)
    //                    w[i] = new Expression(w[i]).Evaluate().ToString();

    //                return w;
    //            }
                
    //                if(HasFunction())
    //                {
                        

    //                }
    //            return new Expression(String).Evaluate().ToString();
    //        }
    //        return "";
    //    }



    //    private string _str;
    //    public string String
    //    {
    //        get { return _str; }
    //        set
    //        {
    //            _str = value;
    //            GetVarsFromString();
    //        }
    //    }
    //    public List<String> GetFuncsString(String str)
    //    {
    //        var s = new List<String>();
    //        var w = str.Split(Convert.ToChar(" "));
    //        foreach (string s1 in w)
    //            if (s1.IndexOf("Function") != -1)
    //                s.Add(s1);
    //        return s;
    //    }

    //    //public List<FuncData> FoundFunctions { get; set; }
    //    //public String Name { get; set; }
    //    //public bool HasErrorFunctions(out string errorst)
    //    //{
    //    //    errorst = "";
      
    //    //    foreach (FuncData funcData in FoundFunctions)
    //    //        if (funcData.HasChild(Name))
    //    //        {
    //    //            errorst = "Referencia circular de las funciones";
    //    //            return true;
    //    //        }
          
    //    //    return false;
    //    //}

    //    //public List<FuncData> GetFuncReal(String str1)
    //    //{
    //    //    var str = GetFuncsString(str1);
    //    //    var res = new List<FuncData>();
    //    //    foreach (String s in str)
    //    //    {
    //    //        int r = 0;
    //    //        if (FindInFuncData(Functions,s.Replace("Function.",""), out r))
    //    //            res.Add(Functions[r]);

    //    //    }
    //    //    return res;

    //    //}
    //    //public bool FindInFuncData(List<FuncData> f,String s, out int r)
    //    //{
    //    //    var re = false;
    //    //    r = -1;
    //    //    foreach (FuncData data in f)
    //    //    {
    //    //        r++;
    //    //        if (data.Name == s)

    //    //            return true;
    //    //    }
    //    //    return false;
    //    //}
    //    //public List<FuncData> Functions{get; set; }

    //    public bool HasFunction()
    //    {

    //        return String.IndexOf("Function") != -1;
    //    }
    //    public bool CheckForErrors(out string errorst)
    //    {
    //        var r = String;
    //        var e = false;
    //        errorst = "";
    //        if (IsIterative())
    //        {
    //            e = HasErrorsData(out errorst);
    //            foreach (DBData dbData in data)
    //                r = r.Replace(dbData.Field, "0");
    //        }
    //        if (HasFunction() && !e)
    //        {
    //            //e = HasErrorFunctions(out errorst);
    //            //foreach (FuncData foundFunction in FoundFunctions)
    //            //    r = r.Replace("Function." + foundFunction.Name, "0");
    //        }
    //        if (!e)
    //        {
    //            mathreal = new Expression(r);
    //            e = !mathreal.HasErrors();
    //            errorst = mathreal.Error;

    //        }

    //        return e;
    //    }

        
    //}
       class DBData
    {
        public DBData(String str, MathParser parser)
        {
            Field = str;
            MathParser = parser;
        }

           public MathParser MathParser;
        private List<String> _values = new List<String>();
        public String Field { get; set; }
        public List<String> Values { get { return _values; } }
        public DataColumn GetColumn()
        {
            DataSet d = null;
            DataColumn res = null;
            var strings = Field.Split(Convert.ToChar("."));
            foreach (DataSet dataSet in MathParser.DataSets)
                if (dataSet.DataSetName == strings[1])
                {
                    d = dataSet;
                    break;
                }
            if (d != null)
            {
                DataTable s = null;
                foreach (DataTable t in d.Tables)
                    if (t.TableName == strings[2])
                    {
                        s = t;
                        break;
                    }
                if (s != null)
                {
                    foreach (DataColumn t in s.Columns)
                        if (t.ColumnName == strings[3])
                        {
                            res = t;
                            break;
                        }
                }
            }

            return res;
        }

        public bool error = false;
        public List<object> GetValuesFromVar()
        {
            List<object> res = new List<object>();
            var column = GetColumn();
            foreach (DataRow row in column.Table.Rows)
                res.Add(row[column.ColumnName]);


            return res;
        }
    }
    public class FuncData
    {
        private Expression mathreal;
        private List<DBData> data = new List<DBData>();
        public FuncData(string name, string value)
        {
            Name = name;
            Value = value;
        }
        private void GetVarsFromString()
        {
            data.Clear();
            var w = Value.Split(Convert.ToChar(" "));
            foreach (string s1 in w)
                if (s1 != "" && s1.IndexOf("dbo") != -1)
                    data.Add(new DBData(s1, MathParser));
           
        }
        public  MathParser MathParser;
        public string Name
        {
            get;
            set;
        }

        public string Value
        {
            get; set; }
        public List<FuncData> ChildFunction =new List<FuncData>();
            public bool IsIterative()
        {
            return Value.IndexOf("dbo") != -1;
        }
              public bool HasErrorsData()
        {
      
            foreach (DBData dbData in data)
                if (dbData.error)
                {
                    ErrorMsg = "Existen datos que no se encuentran en l ajerarquia de datos";
                    return true;
                }
            return false;
        }
  
        public bool  Errors()
        {
            var r = Value;
                    var e = false;
                  
                    if (IsIterative())
                    {
                        e = HasErrorsData();
                        foreach (DBData dbData in data)
                            r = r.Replace(dbData.Field, "0");
                    }
                    //if (HasFunction() && !e)
                    //{
                    //    //e = HasErrorFunctions(out errorst);
                    //    //foreach (FuncData foundFunction in FoundFunctions)
                    //    //    r = r.Replace("Function." + foundFunction.Name, "0");
                    //}
                    if (!e)
                    {
                        mathreal = new Expression(r);
                        e = !mathreal.HasErrors();
                        ErrorMsg = mathreal.Error;

                    }

                    return e;
                
        }

        public String ErrorMsg;
        public object Evaluate ()
        {
            var s = "";
            //if (CheckForErrors(out s))
            //{

                if (IsIterative())
                {
                    var w = new List<string>();
                    var t = data[0].GetColumn().Table.Rows.Count;
                    //aqui hay quer revisar cuando es de difierentes tablar hacer despues

                    for (int i = 0; i < t; i++)
                        w.Add(Value);
                    foreach (DBData dbData in data)
                    {

                        var q = dbData.GetValuesFromVar();
                        for (int i = 0; i < w.Count; i++)
                            w[i] = w[i].Replace(dbData.Field, q[i].ToString());
                    }
                    for (int i = 0; i < t; i++)
                        w[i] = new Expression(w[i]).Evaluate().ToString();

                    return w;
                }

                if (ChildFunction.Count>0)
                {
                    var r = Value;
                    foreach (FuncData funcData in ChildFunction)
                        r = r.Replace(funcData.WholeName, funcData.Evaluate().ToString());
                    return new Expression(r).Evaluate().ToString();

                }
                return new Expression(Value).Evaluate().ToString();
            //}
            return "";
        }

        protected string WholeName
        {
            get { return "Function." + Name; }
        }

        public void Clear()
        {
            foreach (FuncData funcData in ChildFunction)
                funcData.Clear();
            ChildFunction.Clear();
        }
    }
    public class MathParser
    {

        public List<FuncData> FunctionsTree  =new List<FuncData>();


        public FuncData CurrentFunction { get; set; }
        public void FromString(String Name, String Value)
        {
            int r;
            CurrentFunction = new FuncData(Name, Value);
            CurrentFunction.MathParser = this;
            if (FindInFuncData(RealList, CurrentFunction, out r, false))
                CurrentFunction = RealList[r];
            else
            {
                RealList.Add(CurrentFunction);
            BuildTree();
            }
        }

        private List<FuncData> RealList = new List<FuncData>();
        private void ConvertFromFormulas(DSFormulas.T_FormulaDataTable formula)
        {
            RealList.Clear();
            foreach (DSFormulas.T_FormulaRow formulaRow in formula)
            {
                var s = new FuncData(formulaRow.nameformula, formulaRow.valueformula);
                s.MathParser = this;
                RealList.Add(s);
            }
       
        }
        private static bool FindInFuncData(IEnumerable<FuncData> f, FuncData s, out int r,bool value)
        {
            r = -1;

            foreach (FuncData data in f)
                
            {
                r++;
                if(!value)
                {
                if (data.Name == s.Name)

                    return true;
                }
                else
                {
                    if (data.Value.IndexOf(s.Name) != -1)
                        return true;
                }
            }
   
            return false;
        }
        public void BuildTree()
        {
            foreach (FuncData funcData in FunctionsTree)
                funcData.Clear();
            FunctionsTree.Clear();

                int r = 0;
            foreach (FuncData funcData in RealList)
                if (FindInFuncData(RealList, funcData, out r, true))
                    RealList[r].ChildFunction.Add(funcData);
                else
                    FunctionsTree.Add(funcData);
        }
        public void BuildTree(DSFormulas.T_FormulaDataTable formula)
        {
            ConvertFromFormulas(formula);
            BuildTree();
        }
        public List<DataSet> DataSets { get; set; }
        public object Evaluate()
        {
            return CurrentFunction.Evaluate();
           
        }
    }
}
