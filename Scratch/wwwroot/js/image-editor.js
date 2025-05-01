let angle = 0;
let scaleFactor = 1;

function rotate() {
    angle += 45;
    applyTransform();
}

function scale() {
    scaleFactor += 0.1;
    applyTransform();
}

function reset() {
    angle = 0;
    scaleFactor = 1;
    applyTransform();
}

function applyTransform() {
    const img = document.getElementById('uploadedImage');
    img.style.transform = `rotate(${angle}deg) scale(${scaleFactor})`;
}

