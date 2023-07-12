// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const matchImg1 = document.getElementById("match1");
const matchImg2 = document.getElementById("match2");
const matchImg3 = document.getElementById("match3");
const matchImg4 = document.getElementById("match4");
const matchImg5 = document.getElementById("match5");
const matchImg6 = document.getElementById("match6");
const matchImg7 = document.getElementById("match7");
const matchImg8 = document.getElementById("match8");
const matchImg9 = document.getElementById("match9");
const matchImg10 = document.getElementById("match10");
const matchImg11 = document.getElementById("match11");
const matchImg12 = document.getElementById("match12");
const matchImg13 = document.getElementById("match13");
const matchImg14 = document.getElementById("match14");
const matchImg15 = document.getElementById("match15");
const matchImg16 = document.getElementById("match16");

const row1Btn = document.getElementById("row1Btn");
const row2Btn = document.getElementById("row2Btn");
const row3Btn = document.getElementById("row3Btn");
const row4Btn = document.getElementById("row4Btn");

matchImg2.style.visibility = "visible";
matchImg3.style.visibility = "visible";
matchImg4.style.visibility = "visible";

matchImg5.style.visibility = "visible";
matchImg6.style.visibility = "visible";
matchImg7.style.visibility = "visible";
matchImg8.style.visibility = "visible";
matchImg9.style.visibility = "visible";

matchImg10.style.visibility = "visible";
matchImg11.style.visibility = "visible";
matchImg12.style.visibility = "visible";
matchImg13.style.visibility = "visible";
matchImg14.style.visibility = "visible";
matchImg15.style.visibility = "visible";
matchImg16.style.visibility = "visible";

const turnPlayerName = document.getElementById("turnPlayerName");
turnPlayerName.textContent = "Player 1's turn";

/*const p1Turn = true;*/

function passTurn() {
    row1Btn.disabled = false;
    row2Btn.disabled = false;
    row3Btn.disabled = false;
    row4Btn.disabled = false;

    if (matchImg1.style.visibility == "hidden") {
        row1Btn.disabled = true;
    }

    if (matchImg4.style.visibility == "hidden") {
        row2Btn.disabled = true;
    }

    if (matchImg9.style.visibility == "hidden") {
        row3Btn.disabled = true;
    }

    if (matchImg16.style.visibility == "hidden") {
        row4Btn.disabled = true;
    }

    //if (p1Turn == true) {
    //    turnPlayerName.textContent = "Player 1's turn";
    //    p1Turn == false;
    //}

    //if (p1Turn == false) {
    //    turnPlayerName.textContent = "Player 2's turn";
    //    p1Turn == true;
    //}
}

function removeMatchRow1() {
    row2Btn.disabled = true;
    row3Btn.disabled = true;
    row4Btn.disabled = true;

    matchImg1.style.visibility = "hidden";
}

function removeMatchRow2() {
    row1Btn.disabled = true;
    row3Btn.disabled = true;
    row4Btn.disabled = true;

    if (matchImg2.style.visibility == "visible") {
        matchImg2.style.visibility = "hidden";
        return;
    }

    if (matchImg2.style.visibility == "hidden" && matchImg3.style.visibility == "visible") {
        matchImg3.style.visibility = "hidden";
        return;
    }
    

    if (matchImg3.style.visibility == "hidden" && matchImg4.style.visibility == "visible") {
        matchImg4.style.visibility = "hidden";
        return;
    }
}

function removeMatchRow3() {
    row1Btn.disabled = true;
    row2Btn.disabled = true;
    row4Btn.disabled = true;

    if (matchImg5.style.visibility == "visible") {
        matchImg5.style.visibility = "hidden";
        return;
    }

    if (matchImg5.style.visibility == "hidden" && matchImg6.style.visibility == "visible") {
        matchImg6.style.visibility = "hidden";
        return;
    }


    if (matchImg6.style.visibility == "hidden" && matchImg7.style.visibility == "visible") {
        matchImg7.style.visibility = "hidden";
        return;
    }

    if (matchImg7.style.visibility == "hidden" && matchImg8.style.visibility == "visible") {
        matchImg8.style.visibility = "hidden";
        return;
    }

    if (matchImg8.style.visibility == "hidden" && matchImg9.style.visibility == "visible") {
        matchImg9.style.visibility = "hidden";
        return;
    }
}

function removeMatchRow4() {
    row1Btn.disabled = true;
    row2Btn.disabled = true;
    row3Btn.disabled = true;

    if (matchImg10.style.visibility == "visible") {
        matchImg10.style.visibility = "hidden";
        return;
    }

    if (matchImg10.style.visibility == "hidden" && matchImg11.style.visibility == "visible") {
        matchImg11.style.visibility = "hidden";
        return;
    }


    if (matchImg11.style.visibility == "hidden" && matchImg12.style.visibility == "visible") {
        matchImg12.style.visibility = "hidden";
        return;
    }

    if (matchImg12.style.visibility == "hidden" && matchImg13.style.visibility == "visible") {
        matchImg13.style.visibility = "hidden";
        return;
    }

    if (matchImg13.style.visibility == "hidden" && matchImg14.style.visibility == "visible") {
        matchImg14.style.visibility = "hidden";
        return;
    }

    if (matchImg14.style.visibility == "hidden" && matchImg15.style.visibility == "visible") {
        matchImg15.style.visibility = "hidden";
        return;
    }
    if (matchImg15.style.visibility == "hidden" && matchImg16.style.visibility == "visible") {
        matchImg16.style.visibility = "hidden";
        return;
    }

}