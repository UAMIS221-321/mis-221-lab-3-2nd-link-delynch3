string enjoymentLevel = GetEnjoymentLevel();
string stadiumrecommendation = GetStadiumRecommendation(enjoymentLevel);
string gamerecommendation = GetGameRecommendation(stadiumrecommendation);
DisplayStadiumDetails(stadiumrecommendation,gamerecommendation);

static string GetEnjoymentLevel(){
    System.Console.WriteLine("What enjoyment level would you like to attend?");
    return Console.ReadLine();
}

static string GetStadiumRecommendation(string enjoymentLevel){
    if (enjoymentLevel == "Boring"){
        return "Neyland Stadium";
    }
    else if(enjoymentLevel == "Average"){
        return "Jordan-Hare Stadium";
    }
    else if(enjoymentLevel == "Fun"){
        return "Tiger Stadium";
    }
    else if(enjoymentLevel == "Epic"){
        return "Sabam Field at Bryant-Denny Stadium"; 
    }
    else return "Wrong input";

}
static string GetGameRecommendation(string stadium){
     if( stadium == "Neyland Stadium"){
          return " vs Kent State";
     }
     else if( stadium == "Jordan-Hare Stadium"){
         return " vs Kentucky";
      }
      else if( stadium == "Tiger Stadium"){
          return " vs Alabama";
      }
      else if( stadium == "Sabam Field at Bryant-Denny Stadium"){
          return " vs Auburn";

        }
    else return "Wrong Input";
}
static void DisplayStadiumDetails(string stadium, string game){
    Console.WriteLine( stadium + game);
}