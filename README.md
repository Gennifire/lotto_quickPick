# lotto_quickPick
//Fill this in when project is complete.

spooky time halloween lotto number (Ireland) generator.

Version 2 of lotto quick pick generator.

Allows for 10 lines, before locking the generate button and enabling reset button.

Form app with 2 buttons, 11 text boxes, 10 for the lotto numbers, 1 to display the total cost of each ticket line.

Created a random number generator in class and wanted to see if i could expand upon it at home, this time I tried to allow for the user to generate 10 lines at a button click.
Each click is counted and a switch statement is used to populate 10 textBoxes with the randomly generated lotto numbers.

To prevent the same number appearing twice, i used the Fisher-yates algorithm to shuffle the numbers before they are displayed withing the text boxes.


/*----------------------------------------------------------------------------------------------------------------------------------------------------------------*/
Items used: //fill in...

3 methods used in this project: clear();, Btn_pick(); and  Btn_reset; 
Clear(); allows the form to be cleared, this is called in the Btn_reset method to clear all textBoxes after the form has generated 10 rows.

Btn_pick(); this generates an array for the lotto numbers 1- 47;

/*------------------------------------------------------------------------------------*/


New items learned:

Declaring an object properly.
Objects: Random. StringBuilder.

.Join: populate a textBox with an array.

fisher-yates algorithm.


overall this is a simple project, but one i hope to expand on in the future, perhaps even make cross platform.

/*-----------------------------------------------------------------*/


Added a fourth method to hold onto all calculations called them into the button click.

Added a running total to bottom of app. 
Method for populating running total not great, try to add a more efficient method in futher.

