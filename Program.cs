using System;

namespace cBuilder
{
    class Program
    {

    

        public class gitNewRepoBuilder 
        {
            private string _chainOfcommands;  
             public gitNewRepoBuilder() {
                 _chainOfcommands = ""; 
             }

             public gitNewRepoBuilder Init() {
                 _chainOfcommands = "git init" + " \n";
                 return this ; 
             }

             public gitNewRepoBuilder Add(string fileName = "."){
                 _chainOfcommands += "git add " +  fileName + " \n";
                 return this ; 
             }

             public gitNewRepoBuilder Commit(string msg){
                 _chainOfcommands += "git commit -m "+ msg + " \n";
                 return this ; 
             }
             public gitNewRepoBuilder Branch(string branchName){
                 _chainOfcommands += "git branch -M " + branchName + " \n"; 
                 return this ; 
             }

             public gitNewRepoBuilder Remote (string remoteLink) {
                 _chainOfcommands += "git remote add origin " + remoteLink + " \n";
                 return this ;  
             }

             public gitNewRepoBuilder Push (string branchName){
                 _chainOfcommands += "git push -u origin "+ branchName + " \n";
                 return this ;  
             }

             public string Build() {
                 return _chainOfcommands ; 
             }


        }

       
        static void Main(string[] args)
        {
            gitNewRepoBuilder newRepo = new gitNewRepoBuilder();
            string Repo = newRepo
                        .Init()
                        .Add()
                        .Commit("First Commit") 
                        .Branch("main")
                        .Remote("https://github.com/aldundur-Mansour/string-check-order")
                        .Push("main")
                        .Build();

            Console.WriteLine(Repo) ; 
        }
    }
}
