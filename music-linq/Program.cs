using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            IEnumerable<Artist> vernl = Artists.Where(art => art.Hometown == "Mount Vernon");
            foreach(Artist vern in vernl){
                System.Console.WriteLine("Name: {0} & Age: {1}", vern.ArtistName, vern.Age);
            }

            //Who is the youngest artist in our collection of artists?
            List<int> ageList = Artists.Select(art => art.Age).ToList();
            int minAge = ageList[0];
            for(int i = 1; i < ageList.Count; i++){
                if (ageList[i] < minAge){
                    minAge = ageList[i];
                }
            }
            List<Artist> youngest = Artists.Where(art => art.Age == minAge).ToList();
            foreach(Artist youngun in youngest){
                System.Console.WriteLine("{0} is {1} years young/old", youngun.ArtistName, youngun.Age);
            }
            //Display all artists with 'William' somewhere in their real name
            List<Artist> wills = Artists.Where(art => art.RealName.Contains("William")).ToList();
            foreach(Artist willy in wills){
                System.Console.WriteLine(willy.ArtistName);
            }

            //Display the 3 oldest artist from Atlanta
            List<Artist> atlantians = Artists.Where(art => art.Hometown =="Atlanta").OrderBy(x => x.Age).ToList();
            for(int i = atlantians.Count-1; i > atlantians.Count - 4; i--){
                System.Console.WriteLine("{0} is {1}",atlantians[i].ArtistName, atlantians[i].Age);
            }
            // //(Optional) Display the Group Name of all groups that have members that are not from New York City
            List<Artist> nonNyers = Artists.Where(x => x.Hometown != "New York").ToList();
            List<string> query = nonNyers.Join(Groups, 
                                        artist => artist.GroupId,
                                        group => group.Id, 
                                        (Artist, Group)=>{
                                            return Group.GroupName;
                                            }).Distinct().ToList();
            foreach(string q in query){
                System.Console.WriteLine(q);
            }

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
            List<Group> WuTang = Groups.Where(x => x.GroupName == "Wu-Tang Clan").ToList();
            List<Artist> WuTangs = Artists.Join(WuTang,
                                            artist => artist.GroupId,
                                            group => group.Id, (Artist,Group)=>{
                                                return Artist;
                                            }).ToList();
            foreach(Artist WuT in WuTangs){
                System.Console.WriteLine(WuT.ArtistName);
            }

        }
    }
}
