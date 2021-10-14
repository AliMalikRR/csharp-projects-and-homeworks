const imageSlide = document.querySelector('.imageSlide');
const sliderImages = document.querySelectorAll('.imageSlide img');

//Buttons

const prevBtn = document.querySelector('#prevBtn');
const nextBtn = document.querySelector('#nextBtn');

//Counter

let counter = 1;
const size = sliderImages[0].clientWidth

imageSlide.style.transform = 'translateX(' + ( -size * counter ) + 'px)';

//Button listeners

nextBtn.addEventListener('click',()=>{
    if(counter >= sliderImages.length -1) return;
    imageSlide.style.transition = "transform 0.4s ease-in-out";
    counter++;
    imageSlide.style.transform = 'translateX(' + ( -size * counter ) + 'px)';
    console.log('prevBtn, click')
})

prevBtn.addEventListener('click',()=>{
    if(counter <= 0 ) return;
    imageSlide.style.transition = "transform 0.5s ease-in-out";
    counter--;
    imageSlide.style.transform = 'translateX(' + ( -size * counter ) + 'px)';

})

imageSlide.addEventListener('transitionend', ()=>{
    if(sliderImages[counter].id === 'lastClone'){
    imageSlide.style.transition = "none";
    counter = sliderImages.length -2;
    imageSlide.style.transform = 'translateX(' + ( -size * counter ) + 'px)';
    }
    if(sliderImages[counter].id === 'firstClone'){
        imageSlide.style.transition = "none";
        counter = sliderImages.length - counter;
        imageSlide.style.transform = 'translateX(' + ( -size * counter ) + 'px)';
    }
})

// jQuery for the mobile burger menu

$(".burger").on("click", function () {
    $("nav").slideToggle("fast");
});

// Show more toggle on/off with animation

$("#showMore").on('click', function(){
    $("#moreContent").toggle("fast", function(){
    if($(this).is(':hidden')){
    $("#showMore").text("Show Details");
    }else{
    $("#showMore").text("Hide Details")
    }
    });
    });


