let btnUpload = document.querySelector('.upload');
let fileInput = document.querySelector('.file-input');
btnUpload.onclick = function () {
    fileInput.click();
}

let del = document.querySelector('.delete');

fileInput.onchange = function (ev) {
    let files = ev.target.files;
    for (let file of files) {
        let reader = new FileReader();
        let images = document.querySelectorAll('.image img');
        reader.onloadend = function (ev) {
            let img;
            if (images.length == 0) {
                img = document.createElement('img');
                img.setAttribute('src', ev.target.result);
                img.style.height = 200 + 'px';
            } else {
                img = document.querySelector('.image img');
                img.setAttribute('src', ev.target.result);
            }
            del.style.display = 'block';
            btnUpload.style.display = 'none';
            let image = document.querySelector('.basic-info .image');
            image.append(img);
        }
        reader.readAsDataURL(file);
    }
}

del.onclick = function () {
    document.querySelector('.image img').remove();
    btnUpload.style.display = 'block';
    this.style.display='none';
}