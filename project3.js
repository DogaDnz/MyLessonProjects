  
   let midterm1 = Number(prompt("Please enter your first midterm note: "));
   let midterm2 = Number(prompt("Please enter your second midterm note: "));

   let final = Number(prompt("Please enter yourfinal note: "));

 let average = 0.3*midterm1 + 0.3*midterm2 + 0.4*final ;

 if(average >= 60){
    alert("You passed the class!");
    console.log("You passed the class!");
 }

 else{
    alert("You did not pass the class");
   console.log("You did not pass the class");
 }