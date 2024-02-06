
const buttonNo = document.querySelector("#no");
const buttonYes = document.querySelector("#yes");
const h1 = document.querySelector("#pregunta");
let counter = 0;

if (buttonNo) {
    buttonNo.addEventListener("mouseenter", function () {
        const randTop = Math.floor(Math.random() * 80 + 10);
        const randLeft = Math.floor(Math.random() * 80 + 10);

        buttonNo.style.position = "absolute";
        buttonNo.style.top = `${randTop}%`;
        buttonNo.style.left = `${randLeft}%`;

        if (h1) {
            h1.innerText = "Oops, respuesta equivocada!";
            counter += 1;

            if (counter >= 3) {
                h1.innerText = ">:(";
            }
            if (counter >= 6) {
                h1.innerText = "Tengo a tu familia"
            }
        }
    })
}

if (buttonYes) {
    buttonYes.addEventListener("mouseenter", function () {
        h1.innerText = "Pícale pícale";
    })

    buttonYes.addEventListener("mouseout", function () {
        h1.innerText = "Oye regresa";
    })
}

const h1yay = document.querySelector("#yay");
const h4 = document.querySelector("h4");
const bodyyay = document.querySelector(".yes");

if (h1yay && h4) {
    setTimeout(function () {
        h1yay.innerText = ";)";
        h4.style.display = "block"
    }, 3000)
}

if (bodyyay) {
    setInterval(function() {
        const colors = ['rgb(255, 208, 249)', 'rgb(244, 176, 235)', 'rgb(239, 158, 229)','rgb(244, 176, 235)'];
        const currentColor = getComputedStyle(bodyyay).backgroundColor;
        const currentIndex = colors.indexOf(currentColor);
        const nextIndex = (currentIndex + 1) % colors.length;
        bodyyay.style.backgroundColor = colors[nextIndex];
    }, 1000);
}


