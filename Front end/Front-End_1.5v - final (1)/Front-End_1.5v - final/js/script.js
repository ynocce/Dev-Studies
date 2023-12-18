const header = document.querySelector('.header')
const nav = document.querySelector('.header__nav')
const btnMobile = document.querySelector('.header__nav__btnMobile')
const menuMobile = document.querySelector('.header__nav__menu')
const home = document.querySelector('.home')


let sizeHeight = header.offsetHeight;
menuMobile.style.top = `${sizeHeight}px`;
home.style.paddingTop = `${sizeHeight}px`;


btnMobile.addEventListener('click', () => {
  if(nav.classList.contains('active')){
    nav.classList.remove('active')
  }else {
    nav.classList.add('active')
  }
})