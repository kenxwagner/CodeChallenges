
var words = "The sky above the port was the color of television, tuned to a dead channel. All this happened, more or less. I had the story, bit by bit, from various people, and, as generally happens in such cases, each time it was a different story. It was a pleasure to burn.";

function generateIpsum() {
 for(var i = 0; i<1001; i++) {
	var newWords = words.concat(" ", words);
} return newWords.substr(0,1000);   
}

document.getElementById('fill').innerHTML = generateIpsum();