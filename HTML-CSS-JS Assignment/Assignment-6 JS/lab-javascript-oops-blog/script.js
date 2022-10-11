const popUp = () => {
    document.getElementById('popupContact').style.display = 'block';
}

const popDown = () => {
    document.getElementById('popupContact').style.display = 'none';
}

const post = () => {
    var Title = document.getElementById('title').value = null;
    var describe = document.getElementById('detail').value;
    console.log(Title);
    console.log(describe);
    document.getElementById('popupContact').style.display = 'none';
    var myBlog = new Blog(Title, describe);

    myBlog.addImage();
    myBlog.addTitle();
    myBlog.addDescription();
}

class Blog {
    constructor(title, detail) {
        this.title = title;
        this.detail = detail;
    }

    addImage() {
        var img = document.createElement("img");
        img.src = "./assets/java card image.svg";
        var src = document.getElementById("card-text");
        src.appendChild(img);
    }

    addTitle() {
        var title_card = document.createElement('h1');
        title_card.setAttribute("id", "blog-title");
        console.log(title_card);
        document.getElementById('card-text').appendChild(title_card);
        title_card.innerHTML += this.title;
    }

    addDescription() {
        var detail_card = document.createElement('p');
        detail_card.setAttribute("id", "blog-description");
        console.log(detail_card);
        document.getElementById('card-text').appendChild(detail_card);
        detail_card.innerHTML += this.detail;
    }
}
