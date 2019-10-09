



using System.Configuration;


/*
This is an auto generated class
*/
public static class ConnectionStrings{

 public static string local{
        get { return ConfigurationManager.ConnectionStrings["local"].ConnectionString;}
}
 public static string development{
        get { return ConfigurationManager.ConnectionStrings["development"].ConnectionString;}
}
 public static string QA{
        get { return ConfigurationManager.ConnectionStrings["QA"].ConnectionString;}
}
}



