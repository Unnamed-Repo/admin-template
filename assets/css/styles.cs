/*-----------------------------------------------------------------------------------

  Project Name: Investify HTML5 Template
  Author: 
  Support: 
  Description: Investify related HTML5 Template
  Version: 1.0

-----------------------------------------------------------------------------------

/*----------------------------------------*/
/*   Globals Default
/*----------------------------------------*/
@import url("https://fonts.googleapis.com/css2?family=Be+Vietnam+Pro:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&display=swap");
.text-link::after, .app-main-menu .mega-menu li a, .how-it-work-item, .how-it-work-item::before, input[type=radio] ~ label::before {
  -webkit-transition: all 0.3s 0s ease-out;
  -moz-transition: all 0.3s 0s ease-out;
  -ms-transition: all 0.3s 0s ease-out;
  -o-transition: all 0.3s 0s ease-out;
  transition: all 0.3s 0s ease-out;
}

.faq-style-one .accordion .accordion-button::after {
  -webkit-transform: translateY(-50%);
  -moz-transform: translateY(-50%);
  -ms-transform: translateY(-50%);
  -o-transform: translateY(-50%);
  transform: translateY(-50%);
}

:root {
  --ff-body: "Be Vietnam Pro", sans-serif;
  --ff-fontawesome: "Font Awesome 6 Pro";
  --ff-icomoon: "icomoon";
  --white: hsl(0, 0%, 100%);
  --black: hsl(0, 0%, 0%);
  --placeholder: hsla(0, 0%, 0%, 0.5);
  --selection: hsl(0, 0%, 0%);
  --heading: #0c0c14;
  --primary: #013229;
  --secondary: #FF6800;
  --text-primary: #676b71;
  --laundry-white: #F5F8F2;
  --warning: #FFA739;
  --success: #16C113;
  --danger: #F34141;
  --green: #80ED99;
  --yellow: #FFAF34;
  --purple: #6B40EA;
  --fw-normal: normal;
  --fw-thin: 100;
  --fw-elight: 200;
  --fw-light: 300;
  --fw-regular: 400;
  --fw-medium: 500;
  --fw-sbold: 600;
  --fw-bold: 700;
  --fw-ebold: 800;
  --fw-black: 900;
  --fs-body: 16px;
  --fs-p: 16px;
  --fs-h1: 52px;
  --fs-h2: 42px;
  --fs-h3: 32px;
  --fs-h4: 24px;
  --fs-h5: 20px;
  --fs-h6: 16px;
}

/*---------------------------------
/*  Default Spacing
---------------------------------*/
.app-section-space {
  padding-top: 100px;
  padding-bottom: 100px;
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .app-section-space {
    padding-top: 100px;
    padding-bottom: 100px;
  }
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .app-section-space {
    padding-top: 100px;
    padding-bottom: 100px;
  }
}
@media only screen and (min-width: 768px) and (max-width: 991px) {
  .app-section-space {
    padding-top: 80px;
    padding-bottom: 80px;
  }
}
@media only screen and (min-width: 576px) and (max-width: 767px), (max-width: 575px) {
  .app-section-space {
    padding-top: 70px;
    padding-bottom: 70px;
  }
}

.app-section-space-top {
  padding-top: 100px;
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .app-section-space-top {
    padding-top: 100px;
  }
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .app-section-space-top {
    padding-top: 100px;
  }
}
@media only screen and (min-width: 768px) and (max-width: 991px) {
  .app-section-space-top {
    padding-top: 80px;
  }
}
@media only screen and (min-width: 576px) and (max-width: 767px), (max-width: 575px) {
  .app-section-space-top {
    padding-top: 70px;
  }
}

.app-section-space-bottom {
  padding-bottom: 100px;
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .app-section-space-bottom {
    padding-bottom: 100px;
  }
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .app-section-space-bottom {
    padding-bottom: 100px;
  }
}
@media only screen and (min-width: 768px) and (max-width: 991px) {
  .app-section-space-bottom {
    padding-bottom: 80px;
  }
}
@media only screen and (min-width: 576px) and (max-width: 767px), (max-width: 575px) {
  .app-section-space-bottom {
    padding-bottom: 70px;
  }
}

.app-section-title-space {
  margin-bottom: 60px;
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .app-section-title-space {
    margin-bottom: 50px;
  }
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .app-section-title-space {
    margin-bottom: 45px;
  }
}
@media only screen and (min-width: 768px) and (max-width: 991px) {
  .app-section-title-space {
    margin-bottom: 40px;
  }
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px) {
  .app-section-title-space {
    margin-bottom: 35px;
  }
}

/*----------------------------------------*/
/*   Typography scss
/*----------------------------------------*/
* {
  margin: 0;
  padding: 0;
  -webkit-box-sizing: border-box;
  box-sizing: border-box;
}

body {
  font-family: var(--ff-body);
  font-size: 16px;
  font-weight: normal;
  line-height: 1.5;
  color: var(--text-primary);
}

h1,
h2,
h3,
h4,
h5,
h6 {
  color: var(--heading);
  margin-top: 0px;
  line-height: 1.3;
  margin-bottom: 0;
  word-break: break-word;
}

h1,
.h1 {
  line-height: 1.3;
  font-weight: var(--fw-bold);
  font-size: clamp(1.75rem, 1rem + 2vw, 4.375rem);
}

h2,
.h2 {
  font-size: clamp(1.375rem, 0.875rem + 1.5vw, 3.125rem);
  line-height: 1.3;
  font-weight: var(--fw-bold);
}

h3,
.h3 {
  font-size: clamp(1.375rem, 0.875rem + 1.5vw, 2rem);
  font-weight: var(--fw-sbold);
  line-height: 1.33;
}
@media only screen and (min-width: 576px) and (max-width: 767px) {
  h3,
  .h3 {
    font-size: 28px;
  }
}
@media (max-width: 575px) {
  h3,
  .h3 {
    font-size: 24px;
  }
}

h4,
.h4 {
  font-size: clamp(1.375rem, 0.875rem + 1.5vw, 1.5rem);
  font-weight: var(--fw-sbold);
  line-height: 1.4;
}
@media only screen and (min-width: 576px) and (max-width: 767px), (max-width: 575px) {
  h4,
  .h4 {
    font-size: 22px;
  }
}

h5,
.h5 {
  font-size: clamp(1.375rem, 0.875rem + 1.5vw, 1.25rem);
  font-weight: var(--fw-sbold);
  line-height: 1.4;
}
@media (max-width: 575px) {
  h5,
  .h5 {
    font-size: 20px;
  }
}

h6,
.h6 {
  font-size: clamp(1.375rem, 0.875rem + 1.5vw, 1rem);
  font-weight: var(--fw-sbold);
  line-height: 1.4;
}
@media (max-width: 575px) {
  h6,
  .h6 {
    font-size: 18px;
  }
}

ul {
  margin: 0px;
  padding: 0px;
}

p {
  color: var(--text-primary);
  font-size: 1rem;
}
p.b1 {
  font-size: 12px;
  line-height: 1.4;
}
p.b2 {
  font-size: 14px;
  line-height: 1.5;
}
p.b3 {
  font-size: 20px;
  line-height: 1.625;
}
p.b4 {
  font-size: 22px;
  line-height: 1.754;
}
p:last-child {
  margin-bottom: 0px;
}

a {
  text-decoration: none;
}

a,
.btn,
button,
p,
select,
textarea,
img,
svg,
.transition-3,
li,
h1,
h2,
h3,
h4,
h5,
h6 {
  -webkit-transition: all 0.3s 0s ease-out;
  -moz-transition: all 0.3s 0s ease-out;
  -ms-transition: all 0.3s 0s ease-out;
  -o-transition: all 0.3s 0s ease-out;
  transition: all 0.3s 0s ease-out;
}

a:focus,
.button:focus {
  text-decoration: none;
  outline: none;
}

a:focus,
a:hover {
  text-decoration: none;
  color: inherit;
}

a,
button {
  color: inherit;
  outline: none;
  border: none;
  background: transparent;
}

.o-x-clip {
  overflow-x: clip;
}

img {
  max-width: 100%;
  object-fit: cover;
}

button:hover {
  cursor: pointer;
}

button:focus {
  outline: 0;
}

.uppercase {
  text-transform: uppercase;
}

.capitalize {
  text-transform: capitalize;
}

hr:not([size]) {
  border-color: rgba(0, 0, 0, 0.1);
  opacity: 1;
  border-width: 1px;
}

input[type=text],
input[type=search],
input[type=email],
input[type=tel],
input[type=number],
input[type=password],
textarea {
  outline: none;
  background-color: transparent;
  height: 46px;
  width: 100%;
  font-size: 14px;
  border: 1px solid rgba(0, 0, 0, 0.1);
  padding: 0 20px;
  color: var(--text-primary);
  font-size: 14px;
  border-radius: 10px;
}
input[type=text]::-webkit-input-placeholder,
input[type=search]::-webkit-input-placeholder,
input[type=email]::-webkit-input-placeholder,
input[type=tel]::-webkit-input-placeholder,
input[type=number]::-webkit-input-placeholder,
input[type=password]::-webkit-input-placeholder,
textarea::-webkit-input-placeholder { /* Chrome/Opera/Safari */
  font-size: 14px;
}
input[type=text]::-moz-placeholder,
input[type=search]::-moz-placeholder,
input[type=email]::-moz-placeholder,
input[type=tel]::-moz-placeholder,
input[type=number]::-moz-placeholder,
input[type=password]::-moz-placeholder,
textarea::-moz-placeholder { /* Firefox 19+ */
  font-size: 14px;
}
input[type=text]:-moz-placeholder,
input[type=search]:-moz-placeholder,
input[type=email]:-moz-placeholder,
input[type=tel]:-moz-placeholder,
input[type=number]:-moz-placeholder,
input[type=password]:-moz-placeholder,
textarea:-moz-placeholder { /* Firefox 4-18 */
  font-size: 14px;
}
input[type=text]:-ms-input-placeholder,
input[type=search]:-ms-input-placeholder,
input[type=email]:-ms-input-placeholder,
input[type=tel]:-ms-input-placeholder,
input[type=number]:-ms-input-placeholder,
input[type=password]:-ms-input-placeholder,
textarea:-ms-input-placeholder { /* IE 10+  Edge*/
  font-size: 14px;
}
input[type=text]::placeholder,
input[type=search]::placeholder,
input[type=email]::placeholder,
input[type=tel]::placeholder,
input[type=number]::placeholder,
input[type=password]::placeholder,
textarea::placeholder { /* MODERN BROWSER */
  font-size: 14px;
}
input[type=text]:focus,
input[type=search]:focus,
input[type=email]:focus,
input[type=tel]:focus,
input[type=number]:focus,
input[type=password]:focus,
textarea:focus {
  border-color: var(--primary);
}

textarea {
  padding: 14px 24px;
}
textarea:focus {
  border-color: var(--heading);
}

input[type=checkbox] {
  display: none;
}
input[type=checkbox]:checked ~ label::before {
  -webkit-transform: scale(1);
  -moz-transform: scale(1);
  -ms-transform: scale(1);
  -o-transform: scale(1);
  transform: scale(1);
}
input[type=checkbox]:checked ~ label::after {
  background-color: var(--primary);
  border-color: var(--primary);
}
input[type=checkbox]:checked ~ label::before {
  visibility: visible;
  opacity: 1;
}
input[type=checkbox] ~ label {
  position: relative;
  padding-inline-start: 26px;
  z-index: 1;
  font-size: 14px;
}
input[type=checkbox] ~ label::after {
  position: absolute;
  content: "";
  top: 2px;
  inset-inline-start: 0;
  width: 18px;
  height: 18px;
  line-height: 16px;
  text-align: center;
  border: 1px solid #C3C7C9;
  z-index: -1;
  transition: all 0.2s linear;
  -webkit-border-radius: 4px;
  -moz-border-radius: 4px;
  -o-border-radius: 4px;
  -ms-border-radius: 4px;
  border-radius: 4px;
}
input[type=checkbox] ~ label::before {
  position: absolute;
  content: "\f00c";
  top: 3px;
  inset-inline-start: 0px;
  width: 18px;
  height: 18px;
  line-height: 16px;
  text-align: center;
  visibility: hidden;
  opacity: 0;
  color: var(--white);
  transition: all 0.2s linear;
  font-family: var(--ff-fontawesome);
  font-size: 12px;
}
input[type=checkbox] ~ label:hover {
  cursor: pointer;
}

input[type=radio] {
  opacity: 0;
  position: absolute;
}
input[type=radio] ~ label {
  position: relative;
  font-size: 14px;
  line-height: 21px;
  font-weight: 400;
  padding-inline-start: 25px;
  cursor: pointer;
  margin-bottom: 0;
}
input[type=radio] ~ label::before {
  content: "";
  position: absolute;
  top: 3px;
  inset-inline-start: 0;
  width: 16px;
  height: 16px;
  background-color: transparent;
  border: 1px solid rgba(0, 0, 0, 0.3);
  border-radius: 2px;
  border-radius: 50%;
}
input[type=radio] ~ label::after {
  content: " ";
  position: absolute;
  transform: rotate(-45deg);
  opacity: 0;
  transition: all 0.3s;
  width: 8px;
  height: 8px;
  inset-inline-start: 4px;
  background: var(--white);
  border-radius: 50%;
  top: 7px;
}
input[type=radio]:checked ~ label::before {
  border-color: var(--primary);
}
input[type=radio]:checked ~ label::after {
  opacity: 1;
  background-color: var(--primary);
}

*::-moz-selection {
  background: var(--black);
  color: var(--white);
  text-shadow: none;
}

::-moz-selection {
  background: var(--black);
  color: var(--white);
  text-shadow: none;
}

::selection {
  background: var(--black);
  color: var(--white);
  text-shadow: none;
}

*::-moz-placeholder {
  opacity: 1;
  font-size: 14px;
}

*::placeholder {
  opacity: 1;
  font-size: 14px;
  font-weight: 400;
}

/*---------------------------------
  1.2 Common Classes
---------------------------------*/
.w-img img {
  width: 100%;
}

.m-img img {
  max-width: 100%;
}

.fix {
  overflow: hidden;
}

.clear {
  clear: both;
}

.f-left {
  float: left;
}

.f-right {
  float: right;
}

.z-index-1 {
  z-index: 1;
}

.z-index-11 {
  z-index: 11;
}

.p-relative {
  position: relative;
}

.p-absolute {
  position: absolute;
}

.position-absolute {
  position: absolute;
}

.include-bg {
  background-position: center;
  background-size: cover;
  background-repeat: no-repeat;
}

.hr-1 {
  border-top: 1px solid rgb(232, 232, 232);
}

.x-clip {
  overflow-x: clip;
}

.o-visible {
  overflow: visible;
}

.valign {
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  -webkit-box-align: center;
  -ms-flex-align: center;
  align-items: center;
  -webkit-box-pack: center;
  -ms-flex-pack: center;
  justify-content: center;
  -webkit-box-align: center;
  -ms-flex-align: center;
}

/*----------------------------------------
   Text Underline
-----------------------------------------*/
.underline a {
  display: inline;
  background-image: linear-gradient(var(--white), var(--white)), linear-gradient(var(--white), var(--white));
  background-size: 0% 1px, 0 1px;
  background-position: 100% 100%, 0 83%;
  background-repeat: no-repeat;
  transition: background-size 0.4s linear;
  line-height: 1.4;
  padding: 2% 0;
}
.underline a:hover {
  background-size: 0 1px, 100% 1px;
  color: var(--white);
}

/*----------------------------------------
  Bootstrap customize
-----------------------------------------*/
.container, .container-fluid, .container-lg, .container-md, .container-sm, .container-xl, .container-xxl {
  --bs-gutter-x: 30px;
}

@media (min-width: 1601px) {
  .container,
  .container-lg,
  .container-md,
  .container-sm,
  .container-xl,
  .container-xxl {
    max-width: 1600px;
  }
}
.row {
  --bs-gutter-x: 30px;
}

.g-0, .gx-0 {
  --bs-gutter-x: ;
}

.g-0, .gy-0 {
  --bs-gutter-y: 0 ;
}

.g-10,
.gx-10 {
  --bs-gutter-x: 10px;
}

.gy-12 {
  --bs-gutter-y: 12px;
}

.gy-15 {
  --bs-gutter-y: 15px;
}

.gx-15 {
  --bs-gutter-x: 15px;
}

.g-20 {
  --bs-gutter-x: 20px;
  --bs-gutter-y: 20px;
}

.gy-20 {
  --bs-gutter-y: 20px;
}

.gx-20 {
  --bs-gutter-x: 20px;
}

.gy-20 {
  --bs-gutter-y: 20px;
}

.gx-24 {
  --bs-gutter-x: 24px;
}

.gy-24 {
  --bs-gutter-y: 24px;
}

.g-30,
.gx-30 {
  --bs-gutter-x: 30px;
}

.g-30,
.gy-30 {
  --bs-gutter-y: 30px;
}

.g-40,
.gx-40 {
  --bs-gutter-x: 40px;
}

.g-40,
.gy-40 {
  --bs-gutter-y: 40px;
}

.g-50,
.gx-50 {
  --bs-gutter-x: 50px;
}

.g-50,
.gy-50 {
  --bs-gutter-y: 50px;
}

.g-60,
.gy-60 {
  --bs-gutter-y: 60px;
}

/*----------------------------------------
  Body Overlay 
-----------------------------------------*/
.body-overlay {
  background-color: #000000;
  height: 100%;
  width: 100%;
  position: fixed;
  top: 0;
  z-index: 9999;
  inset-inline-start: 0;
  opacity: 0;
  visibility: hidden;
  -webkit-transition: all 0.3s 0s ease-out;
  -moz-transition: all 0.3s 0s ease-out;
  -ms-transition: all 0.3s 0s ease-out;
  -o-transition: all 0.3s 0s ease-out;
  transition: all 0.3s 0s ease-out;
}

.body-overlay {
  background-color: #000000;
  height: 100%;
  width: 100%;
  position: fixed;
  top: 0;
  z-index: 9999;
  inset-inline-start: 0;
  opacity: 0;
  visibility: hidden;
  -webkit-transition: all 0.3s 0s ease-out;
  -moz-transition: all 0.3s 0s ease-out;
  -ms-transition: all 0.3s 0s ease-out;
  -o-transition: all 0.3s 0s ease-out;
  transition: all 0.3s 0s ease-out;
}

.body-overlay.opened {
  opacity: 0.7;
  visibility: visible;
}

/*----------------------------------------
  Mfp customize
-----------------------------------------*/
.mfp-iframe-holder .mfp-content {
  line-height: 0;
  width: 100%;
  max-width: 1280px;
}
@media only screen and (min-width: 1400px) and (max-width: 1599px), only screen and (min-width: 1600px) and (max-width: 1800px) {
  .mfp-iframe-holder .mfp-content {
    max-width: 1000px;
  }
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .mfp-iframe-holder .mfp-content {
    max-width: 850px;
  }
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .mfp-iframe-holder .mfp-content {
    max-width: 820px;
  }
}
@media only screen and (min-width: 768px) and (max-width: 991px) {
  .mfp-iframe-holder .mfp-content {
    max-width: 750px;
  }
}

.mfp-close {
  -webkit-transform: rotate(0deg);
  -ms-transform: rotate(0deg);
  transform: rotate(0deg);
}
.mfp-close:hover {
  color: var(--white);
}
.mfp-close::after {
  position: absolute;
  content: "\f00d";
  height: 100%;
  width: 100%;
  font-family: var(--ff-fontawesome);
  font-size: 31px;
  font-weight: 200;
  inset-inline-end: -20px;
  margin-top: -25px;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .mfp-close::after {
    inset-inline-end: 15px;
    margin-top: -30px;
  }
}

/*----------------------------------------*/
/* how-it-work css
/*----------------------------------------*/
.how-it-work-shapes .shape-one {
  position: absolute;
  top: 100px;
  inset-inline-end: 0;
  max-width: 161px;
  -webkit-animation: apSpinner 6s infinite linear;
  animation: apSpinner 6s infinite linear;
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .how-it-work-shapes .shape-one {
    max-width: 101px;
  }
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .how-it-work-shapes .shape-one {
    max-width: 80px;
  }
}
@media only screen and (min-width: 768px) and (max-width: 991px) {
  .how-it-work-shapes .shape-one {
    max-width: 80px;
  }
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px) {
  .how-it-work-shapes .shape-one {
    display: none;
  }
}
.how-it-work-shapes .shape-two {
  position: absolute;
  inset-inline-start: -80px;
  bottom: 70px;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .how-it-work-shapes .shape-two {
    max-width: 80px;
  }
}

.how-it-work-grid {
  display: grid;
  grid-template-columns: repeat(4, 1fr);
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .how-it-work-grid {
    grid-template-columns: repeat(3, 1fr);
  }
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .how-it-work-grid {
    grid-template-columns: repeat(2, 1fr);
  }
}
@media (max-width: 480px) {
  .how-it-work-grid {
    grid-template-columns: 1fr;
  }
}

.how-it-work-item {
  border-left: 1px solid #C9C8D2;
  padding: 65px 50px 65px;
  position: relative;
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .how-it-work-item {
    padding: 55px 30px 55px;
  }
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px) {
  .how-it-work-item {
    padding: 45px 30px 45px;
  }
}
.how-it-work-item::before {
  position: absolute;
  content: "";
  height: 10px;
  width: 100%;
  background-color: var(--secondary);
  opacity: 0;
  visibility: hidden;
  top: -1px;
  left: 0;
}
.how-it-work-item:nth-child(-n+4) {
  border-bottom: 1px solid #C9C8D2;
  border-top: 1px solid #C9C8D2;
}
.how-it-work-item:nth-child(n+4) {
  border-bottom: 1px solid #C9C8D2;
}
.how-it-work-item:nth-child(4n), .how-it-work-item:nth-child(8n), .how-it-work-item:nth-child(12n) {
  border-right: 1px solid #C9C8D2;
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .how-it-work-item:nth-child(4) {
    border-top: 0;
    border-right: 0;
  }
  .how-it-work-item:nth-child(3n) {
    border-right: 1px solid #C9C8D2;
  }
}
@media (max-width: 480px), (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .how-it-work-item:nth-child(1), .how-it-work-item:nth-child(2) {
    border-bottom: 0;
  }
  .how-it-work-item:nth-child(2n) {
    border-right: 1px solid #C9C8D2;
  }
}
.how-it-work-item:hover {
  background: #FFEFE4;
}
.how-it-work-item:hover::before {
  opacity: 1;
  visibility: visible;
}
.how-it-work-item .thumb {
  margin-bottom: 35px;
}
.how-it-work-item .contents .title {
  font-size: 20px;
  margin-bottom: 15px;
}
.how-it-work-item .contents .title:hover {
  color: var(--primary);
}
.how-it-work-item .contents .title:hover a:hover {
  color: var(--secondary);
}

.rewards-point-item {
  padding: 35px 40px 20px;
  background: rgba(255, 255, 255, 0.1);
  border: 1px solid rgba(255, 255, 255, 0.3);
  backdrop-filter: blur(42px);
  border-radius: 10px;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .rewards-point-item {
    padding: 30px 25px 35px;
  }
}
@media (max-width: 480px) {
  .rewards-point-item {
    padding: 25px 20px 30px;
  }
}
.rewards-point-item .heading {
  border-bottom: 1px solid rgba(255, 255, 255, 0.3);
  margin-bottom: 15px;
  padding-bottom: 25px;
}
.rewards-point-item .heading .title {
  font-size: 28px;
  color: var(--white);
}
@media only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .rewards-point-item .heading .title {
    font-size: 24px;
  }
}
@media (max-width: 575px) {
  .rewards-point-item .heading .title {
    font-size: 20px;
  }
}

.reward-table table {
  border-spacing: 0px 20px;
  border-collapse: separate;
  margin-bottom: 0;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px) {
  .reward-table table {
    min-width: 650px;
  }
}
.reward-table table thead tr th {
  color: rgba(0, 0, 0, 0.6);
  font-size: 14px;
  font-weight: 600;
  border: 0;
  background: transparent;
}
.reward-table table tbody tr td {
  background: var(--aliceBlue);
  border-inline-start: 0;
  border-inline-end: 0;
  background: rgba(255, 255, 255, 0.2);
  box-shadow: 0px 4px 10px rgba(0, 101, 255, 0.04);
  vertical-align: middle;
  padding: 20px 20px;
  border-bottom: 1px solid rgba(255, 255, 255, 0.2);
}
@media (max-width: 575px) {
  .reward-table table tbody tr td {
    font-size: 14px;
  }
}
.reward-table table tbody tr td:first-child {
  border-inline-start: 1px solid rgba(255, 255, 255, 0.2);
}
.reward-table table tbody tr td:last-child {
  border-inline-end: 1px solid rgba(255, 255, 255, 0.2);
}
.reward-table table tbody tr td:first-child {
  border-radius: 8px 0px 0px 8px;
}
[dir=rtl] .reward-table table tbody tr td:first-child {
  border-radius: 0px 8px 8px 0px;
}
.reward-table table tbody tr td:last-child {
  border-radius: 0px 8px 8px 0px;
  text-align: end;
}
[dir=rtl] .reward-table table tbody tr td:last-child {
  border-radius: 8px 0px 0px 8px;
}

.admin-item {
  display: flex;
  align-items: center;
  gap: 12px;
}
.admin-item .admin-thumbnail {
  max-width: 44px;
  flex: 0 0 auto;
}
.admin-item .admin-info .admin-name {
  font-size: 18px;
  color: var(--white);
  margin-bottom: 5px;
  font-weight: 500;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px), only screen and (min-width: 1200px) and (max-width: 1399px), only screen and (min-width: 1400px) and (max-width: 1599px), only screen and (min-width: 1600px) and (max-width: 1800px) {
  .admin-item .admin-info .admin-name {
    font-size: 16px;
  }
}
@media (max-width: 575px) {
  .admin-item .admin-info .admin-name {
    font-size: 14px;
  }
}
.admin-item .admin-info .description {
  font-size: 12px;
  color: var(--white);
}

/*----------------------------------------*/
/* Deposits style
/*----------------------------------------*/
.deposits-main {
  background: #F5F8F2;
  border-radius: 30px;
  padding: 90px 50px 30px;
  position: relative;
  z-index: 2;
  overflow: hidden;
}
@media (max-width: 480px) {
  .deposits-main {
    padding: 50px 20px 30px;
  }
}
.deposits-main::before {
  content: "";
  position: absolute;
  width: 200px;
  height: 358px;
  background: rgba(21, 175, 92, 0.4);
  filter: blur(157px);
  transform: rotate(-21.4deg);
  inset-inline-end: 20px;
  top: 24px;
  z-index: -1;
}
.deposits-main::after {
  content: "";
  position: absolute;
  width: 200px;
  height: 358px;
  background: rgba(255, 104, 0, 0.3);
  filter: blur(157px);
  transform: rotate(-21.4deg);
  bottom: 76px;
  inset-inline-start: 34px;
}
.deposits-main .shape-one {
  position: absolute;
  inset-inline-end: 15px;
  bottom: 56%;
  z-index: -1;
  -webkit-animation: tdZoom 4s infinite linear;
  animation: tdZoom 4s infinite linear;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .deposits-main .shape-one {
    display: none;
  }
}
.deposits-main .shape-two {
  position: absolute;
  top: 40px;
  inset-inline-start: 42px;
  z-index: -1;
}
@media only screen and (min-width: 768px) and (max-width: 991px) {
  .deposits-main .shape-two {
    max-width: 65px;
  }
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px) {
  .deposits-main .shape-two {
    display: none;
  }
}

/*----------------------------------------*/
/* Payment css
/*----------------------------------------*/
.payment-gateway-shapes .shape-one {
  position: absolute;
  bottom: 20%;
  inset-inline-start: 41px;
  z-index: -1;
  max-width: 102px;
  -webkit-animation: apSpinner 6s infinite linear;
  animation: apSpinner 6s infinite linear;
}
.payment-gateway-shapes .shape-two {
  position: absolute;
  top: 120px;
  inset-inline-start: 41%;
  z-index: -1;
  animation: eduvibe-rotate-x 15s infinite linear;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .payment-gateway-shapes .shape-two {
    display: none;
  }
}

.payment-gateway-grid {
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  gap: 30px;
  background: rgba(35, 95, 62, 0.1);
  border: 1px solid rgba(255, 255, 255, 0.3);
  backdrop-filter: blur(42px);
  border-radius: 16px;
  padding: 50px 50px;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px) {
  .payment-gateway-grid {
    padding: 30px 30px;
  }
}
@media (max-width: 480px) {
  .payment-gateway-grid {
    grid-template-columns: repeat(2, 1fr);
  }
}

.payment-gateway-item {
  background: var(--white);
  box-shadow: 0px 0px 25px rgba(108, 59, 235, 0.12);
  border-radius: 24px;
  height: 97px;
  display: inline-flex;
  align-items: center;
  justify-content: center;
  padding: 15px 15px;
}

.payment-gateway-thumb {
  max-width: 242px;
}
.payment-gateway-thumb img {
  width: 100%;
}

/*----------------------------------------*/
/* Table style
/*----------------------------------------*/
.withdraw-table table {
  border-spacing: 0px 20px;
  border-collapse: separate;
  margin-bottom: 0;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .withdraw-table table {
    min-width: 850px;
  }
}
.withdraw-table table thead tr th {
  color: var(--heading);
  font-size: 16px;
  font-weight: 600;
  border: 0;
  background: transparent;
  padding: 0;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .withdraw-table table thead tr th {
    font-size: 14px;
  }
}
.withdraw-table table tbody tr {
  box-shadow: 0px 0px 4px rgba(19, 110, 249, 0.1);
}
.withdraw-table table tbody tr td {
  font-weight: 600;
  padding: 14px 0px;
  border: 0;
  background: rgba(255, 255, 255, 0.96);
  vertical-align: middle;
}
.withdraw-table table tbody tr td:first-child {
  border-radius: 10px 0px 0px 10px;
  padding-inline-start: 20px;
}
.withdraw-table table tbody tr td:last-child {
  border-radius: 0px 10px 10px 0px;
  padding-inline-end: 20px;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .withdraw-table table tbody tr td {
    font-size: 14px;
  }
}

.custom-table-description {
  display: flex;
  align-items: start;
  gap: 10px;
}
.custom-table-description .thumb {
  max-width: 33px;
  border: 1px solid rgba(0, 0, 0, 0.2);
  -webkit-border-radius: 50%;
  -moz-border-radius: 50%;
  -o-border-radius: 50%;
  -ms-border-radius: 50%;
  border-radius: 50%;
  flex: 0 0 auto;
}
.custom-table-description .contents .title {
  font-size: 18px;
  margin-bottom: 5px;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .custom-table-description .contents .title {
    font-size: 16px;
  }
}
.custom-table-description .contents .description {
  font-size: 12px;
  font-weight: 500;
}

.deposits-toggle,
.deposits-toggler {
  display: inline-block;
  vertical-align: middle;
}

.deposits-toggler {
  transition: 0.2s;
  cursor: pointer;
  font-weight: 600;
  font-size: 18px;
  text-align: center;
  color: rgba(1, 50, 41, 0.7);
}
@media (max-width: 575px) {
  .deposits-toggler {
    font-size: 16px;
  }
}

.deposits-toggler.deposits_tabs_active {
  color: var(--primary);
}

.deposits-toggler--is-active {
  color: var(--heading);
}

.deposits-toggle {
  position: relative;
  width: 60px;
  height: 30px;
  border-radius: 100px;
  background-color: #235F3E;
  overflow: hidden;
}

.deposits-switch {
  position: absolute;
  left: 2px;
  top: 2px;
  bottom: 2px;
  right: 53.3%;
  background-color: var(--white);
  border-radius: 36px;
  z-index: 1;
  transition: 0.25s cubic-bezier(0.785, 0.135, 0.15, 0.86);
  transition-property: left, right;
  transition-delay: 0s, 0.08s;
  box-shadow: 0px 2px 4px rgba(0, 20, 128, 0.3);
}

.deposits-hide {
  display: none;
}

.deposits-different-inner {
  margin-top: 35px;
  margin-bottom: 40px;
}

.deposits-different {
  display: inline-flex;
  align-items: center;
  justify-content: center;
  background: rgba(35, 95, 62, 0.15);
  border-radius: 36px;
  text-align: center;
  padding: 17.5px 40px;
  gap: 20px;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px) {
  .deposits-different {
    gap: 16px;
  }
}
.deposits-different .analisis-check {
  position: absolute;
  display: block;
  cursor: pointer;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  opacity: 0;
  z-index: 6;
}
.deposits-different .analisis-check:checked ~ .deposits-switch {
  right: 2px;
  left: 53%;
  transition: 0.25s cubic-bezier(0.785, 0.135, 0.15, 0.86);
  transition-property: left, right;
  transition-delay: 0.08s, 0s;
}

/*----------------------------------------*/
/* FAQ style
/*----------------------------------------*/
.faq-overlay {
  position: relative;
  z-index: 5;
}
.faq-overlay:before {
  position: absolute;
  content: "";
  height: 100%;
  width: 100%;
  background: linear-gradient(0deg, rgba(0, 0, 0, 0.7), rgba(0, 0, 0, 0.7));
  top: 0;
  inset-inline-start: 0;
  z-index: -1;
}

.faq-thumb {
  position: absolute;
  inset-inline-start: 0;
  bottom: 100px;
  width: 36.2%;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .faq-thumb {
    position: inherit;
    width: 100%;
    margin-bottom: 50px;
  }
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .faq-thumb {
    width: 48.2%;
  }
}
@media only screen and (min-width: 1400px) and (max-width: 1599px) {
  .faq-thumb {
    width: 48.2%;
  }
}
.faq-thumb img {
  border-radius: 0px 10px 10px 0;
  width: 100%;
}

.faq-style-one .accordion .accordion-button {
  padding: 22px 40px 23px 25px;
  font-size: 18px;
  font-weight: 700;
  background: rgba(255, 255, 255, 0.3);
  backdrop-filter: blur(42px);
  color: var(--white);
}
@media (max-width: 575px) {
  .faq-style-one .accordion .accordion-button {
    font-size: 18px;
  }
}
@media (max-width: 480px) {
  .faq-style-one .accordion .accordion-button {
    font-size: 16px;
    padding: 21px 30px 20px 20px;
  }
}
.faq-style-one .accordion .accordion-button:not(.collapsed) {
  background: var(--white);
  border: 0;
  border-radius: 0;
  color: var(--heading);
  box-shadow: none;
}
.faq-style-one .accordion .accordion-button:not(.collapsed):after {
  color: var(--white);
  content: "+";
}
.faq-style-one .accordion .accordion-button::after {
  border: none;
  background: transparent;
  position: absolute;
  inset-inline-end: 30px;
  content: "\f068";
  background-image: none;
  font-family: var(--ff-fontawesome);
  font-size: 12px;
  font-weight: 400;
  height: 20px;
  width: 20px;
  line-height: 20px;
  -webkit-border-radius: 50%;
  -moz-border-radius: 50%;
  -o-border-radius: 50%;
  -ms-border-radius: 50%;
  border-radius: 50%;
  background-color: rgba(var(--primary), 0.1);
  text-align: center;
  top: 50%;
}
@media (max-width: 575px) {
  .faq-style-one .accordion .accordion-button::after {
    inset-inline-end: 20px;
  }
}
.faq-style-one .accordion .accordion-button:focus {
  box-shadow: none;
}
.faq-style-one .accordion .accordion-button span {
  padding-inline-end: 7px;
  display: inline-block;
  transition: none;
}
.faq-style-one .accordion .accordion-body {
  padding-inline-start: 25px;
  padding-inline-end: 25px;
  background: var(--white);
  padding-bottom: 25px;
  border-radius: 0px;
  padding-top: 0px;
}
@media (max-width: 480px) {
  .faq-style-one .accordion .accordion-body {
    padding-inline-start: 20px;
    padding-inline-end: 20px;
  }
}
.faq-style-one .accordion .accordion-body .description :link {
  color: var(--primary);
  text-decoration: underline;
}
.faq-style-one .accordion .accordion-body .accordion-body-list {
  margin-top: 14px;
}
.faq-style-one .accordion .accordion-body .accordion-body-list ul li:not(:last-child) {
  margin-bottom: 7px;
}
.faq-style-one .accordion .accordion-item {
  box-shadow: 0px 4px 80px rgba(0, 0, 0, 0.08);
  background: var(--aliceBlue);
  border: 1px solid rgba(0, 101, 255, 0.2);
  border-radius: 10px;
  overflow: hidden;
}
.faq-style-one .accordion .accordion-item:not(:last-child) {
  margin-bottom: 20px;
}
.faq-style-one .accordion .accordion-item:first-of-type .accordion-button, .faq-style-one .accordion .accordion-item:first-of-type .accordion-button {
  border-top-left-radius: 0;
  border-top-right-radius: 0;
}

/*----------------------------------------*/
/* ranking-badge css
/*----------------------------------------*/
.ranking-badge-grid {
  display: grid;
  grid-template-columns: auto auto auto auto auto;
  justify-content: space-between;
  gap: 50px 30px;
}
@media only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .ranking-badge-grid {
    grid-template-columns: repeat(3, 1fr);
  }
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px) {
  .ranking-badge-grid {
    grid-template-columns: repeat(2, 1fr);
  }
}
@media (max-width: 480px) {
  .ranking-badge-grid {
    grid-template-columns: 1fr;
  }
}

.ranking-badge-icon span {
  width: 168px;
  height: 168px;
  background: rgba(255, 104, 0, 0.2);
  display: inline-flex;
  align-items: center;
  justify-content: center;
  border-radius: 50%;
  margin-bottom: 30px;
}
@media (max-width: 575px) {
  .ranking-badge-icon span {
    width: 128px;
    height: 128px;
  }
}

.ranking-badge-item {
  text-align: center;
}

.anking-badge-content .title {
  font-size: 24px;
  margin-bottom: 10px;
}
@media (max-width: 575px) {
  .anking-badge-content .title {
    font-size: 20px;
  }
}
.anking-badge-content .title a:hover {
  color: var(--secondary);
}
.anking-badge-content .description {
  font-weight: 500;
  font-size: 14px;
}

.ranking-badge-shapes .shape-one {
  position: absolute;
  top: 13%;
  inset-inline-start: 30%;
  z-index: -1;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .ranking-badge-shapes .shape-one {
    display: none;
  }
}
@media (max-width: 575px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .ranking-badge-shapes .shape-one {
    top: 8%;
    inset-inline-start: 10%;
    max-width: 60px;
  }
}
.ranking-badge-shapes .shape-two {
  position: absolute;
  inset-inline-end: -130px;
  bottom: 63px;
  z-index: -1;
}
@media (max-width: 575px) {
  .ranking-badge-shapes .shape-two {
    display: none;
  }
}

/*----------------------------------------*/
/* Footer style
/*----------------------------------------*/
.footer-section.footer-primary {
  position: relative;
  margin-top: -100px;
}
.footer-section .footer-main {
  display: -ms-grid;
  display: -moz-grid;
  display: grid;
  grid-template-columns: 25% 17% 17% 16% 17%;
  justify-content: space-between;
  padding-top: 200px;
  padding-bottom: 50px;
  border-top: 1px solid rgba(255, 255, 255, 0.1);
  border-bottom: 1px solid rgba(255, 255, 255, 0.1);
  gap: 50px 30px;
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .footer-section .footer-main {
    grid-template-columns: 30% 30% 25%;
  }
}
@media xs, only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .footer-section .footer-main {
    grid-template-columns: repeat(2, 1fr);
    padding-top: 260px;
    padding-bottom: 65px;
  }
}
@media (max-width: 575px) {
  .footer-section .footer-main {
    grid-template-columns: 1fr;
    padding-top: 35px;
    padding-bottom: 35px;
  }
}
.footer-section .footer-wg-title {
  margin-bottom: 20px;
}
.footer-section .footer-wg-title h5 {
  font-size: 24px;
  font-weight: 500;
  color: var(--white);
}
@media (max-width: 575px), only screen and (min-width: 992px) and (max-width: 1199px), only screen and (min-width: 1200px) and (max-width: 1399px), only screen and (min-width: 1400px) and (max-width: 1599px), only screen and (min-width: 1600px) and (max-width: 1800px) {
  .footer-section .footer-wg-title h5 {
    font-size: 20px;
  }
}
.footer-section .footer-social ul {
  display: flex;
  align-items: center;
  gap: 10px 15px;
}
.footer-section .footer-social ul li {
  list-style: none;
}
.footer-section .footer-social ul li a {
  width: 24px;
  height: 24px;
  display: -webkit-inline-box;
  display: -moz-inline-box;
  display: -ms-inline-flexbox;
  display: -webkit-inline-flex;
  display: inline-flexbox;
  display: inline-flex;
  align-items: center;
  justify-content: center;
  border-radius: 50%;
  border: 1px solid var(--primary);
  color: var(--primary);
  font-size: 14px;
  background-color: var(--white);
}
.footer-section .footer-social ul li a:hover {
  transform: translateY(-2px);
  background-color: var(--secondary);
  color: var(--white);
  border-color: transparent;
}
.footer-section .footer-logo {
  margin-bottom: 40px;
}
.footer-section .footer-intro-main .description {
  color: var(--white);
  max-width: 325px;
}

.footer-links ul li {
  list-style: none;
}
.footer-links ul li:not(:last-child) {
  margin-bottom: 15px;
}
.footer-links ul li a {
  color: var(--white);
}
.footer-links ul li a:hover {
  color: var(--secondary);
}

.footer-info:not(:last-child) {
  margin-bottom: 20px;
}
.footer-info .heading .title {
  color: rgba(255, 255, 255, 0.8);
  font-size: 14px;
  font-weight: 400;
  margin-bottom: 5px;
}
.footer-info .icon-info {
  display: flex;
  align-items: center;
  gap: 5px;
}
.footer-info .icon-info i {
  font-size: 20px;
  position: relative;
  top: 2px;
  color: var(--white);
}
.footer-info .icon-info .title {
  font-size: 16px;
  font-weight: 600;
  color: var(--white);
}
.footer-info .icon-info .title a:hover {
  color: var(--secondary);
}

.footer-bottom .footer-bottom-inner {
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding: 28px 0;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px) {
  .footer-bottom .footer-bottom-inner {
    gap: 10px 20px;
    flex-wrap: wrap;
    justify-content: center;
  }
}
.footer-bottom .footer-bottom-inner .footer-copyright {
  text-align: center;
}
.footer-bottom .footer-bottom-inner .footer-copyright .description {
  font-size: 16px;
  font-weight: 500;
  color: rgba(255, 255, 255, 0.7);
}
.footer-bottom .footer-bottom-inner .footer-bottom-links ul {
  display: flex;
  align-items: center;
  gap: 10px 27px;
}
.footer-bottom .footer-bottom-inner .footer-bottom-links ul li {
  list-style: none;
}
.footer-bottom .footer-bottom-inner .footer-bottom-links ul li a {
  font-size: 16px;
  font-weight: 500;
  color: rgba(255, 255, 255, 0.7);
}
.footer-bottom .footer-bottom-inner .footer-bottom-links ul li a:hover {
  color: var(--primary);
}

/*----------------------------------------*/
/* fun fact style
/*----------------------------------------*/
.fun-fact-shapes .shape-one {
  position: absolute;
  bottom: 50px;
  inset-inline-start: 134px;
  z-index: -1;
}
.fun-fact-shapes .shape-two {
  position: absolute;
  inset-inline-end: 84px;
  top: 70px;
  z-index: -1;
}

.fun-fact-counter-grid {
  display: -ms-grid;
  display: -moz-grid;
  display: grid;
  grid-template-columns: repeat(4, 1fr);
  align-items: center;
  position: relative;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .fun-fact-counter-grid {
    grid-template-columns: repeat(2, 1fr);
  }
}
@media (max-width: 480px) {
  .fun-fact-counter-grid {
    grid-template-columns: 1fr;
  }
}

.fun-fact-item {
  position: relative;
  background: var(--white);
  box-shadow: 5px 5px 40px rgba(0, 0, 0, 0.08);
  padding: 50px 40px;
  text-align: center;
}
.fun-fact-item .icon {
  margin-bottom: 25px;
}
.fun-fact-item .content .title,
.fun-fact-item .content span {
  font-family: var(--ff-body);
  font-size: 36px;
  color: var(--heading);
  font-weight: 700;
  line-height: 1;
}
@media only screen and (min-width: 1200px) and (max-width: 1399px), only screen and (min-width: 768px) and (max-width: 991px) {
  .fun-fact-item .content .title,
  .fun-fact-item .content span {
    font-size: 36px;
  }
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .fun-fact-item .content .title,
  .fun-fact-item .content span {
    font-size: 36px;
  }
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px) {
  .fun-fact-item .content .title,
  .fun-fact-item .content span {
    font-size: 32px;
  }
}
.fun-fact-item .content .description {
  font-weight: 500;
  margin-top: 25px;
}

/*----------------------------------------*/
/*  Main menu css
/*----------------------------------------*/
.app-main-menu.has-top ul > li > a {
  font-size: 15px;
}
.app-main-menu > ul {
  display: inline-flex;
  gap: 20px;
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .app-main-menu > ul {
    gap: 15px;
  }
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .app-main-menu > ul {
    gap: 8px;
  }
}
.app-main-menu > ul > li > a {
  position: relative;
}
.app-main-menu > ul > li:last-child a::before {
  display: none;
}
.app-main-menu > ul > li:hover > a {
  color: var(--secondary);
}
.app-main-menu > ul > li:hover > ul {
  opacity: 1;
  pointer-events: all;
}
.app-main-menu > ul > li:hover > ul.dp-menu li:hover > ul {
  opacity: 1;
  pointer-events: all;
  inset-inline-start: 100%;
}
.app-main-menu > ul > li:has(ul) > a::after {
  content: "\f107";
  font-family: var(--ff-fontawesome);
  margin-inline-start: 5px;
  font-weight: 500;
  font-size: 13px;
  position: relative;
  top: 2px;
}
[dir=rtl] .app-main-menu > ul > li:has(ul) > a::after {
  margin-inline-end: 5px;
}
.app-main-menu > ul > li > ul.dp-menu > li.menu-item-has-children > a {
  position: relative;
}
.app-main-menu > ul > li > ul.dp-menu > li.menu-item-has-children > a:before {
  position: absolute;
  inset-inline-end: 0;
  content: "\f054";
  transform: translateY(1px);
  font-size: 12px;
  color: var(--heading);
  font-family: var(--ff-fontawesome);
  font-weight: 400;
  margin-inline-start: 5px;
  display: inline-block;
  transition: all 0.3s ease-out 0s;
}
[dir=rtl] .app-main-menu > ul > li > ul.dp-menu > li.menu-item-has-children > a:before {
  inset-inline-start: 0;
  inset-inline-end: auto;
  content: "\f053";
}
.app-main-menu > ul > li > ul.dp-menu > li.menu-item-has-children ul.dp-menu li.menu-item-has-children > a {
  position: relative;
}
.app-main-menu > ul > li > ul.dp-menu > li.menu-item-has-children ul.dp-menu li.menu-item-has-children > a::before {
  position: absolute;
  inset-inline-end: 0;
  content: "\f054";
  transform: translateY(1px);
  font-size: 12px;
  font-family: var(--ff-fontawesome);
  font-weight: 400;
  margin-inline-start: 5px;
  display: inline-block;
  transition: all 0.3s ease-out 0s;
}
[dir=rtl] .app-main-menu > ul > li > ul.dp-menu > li.menu-item-has-children ul.dp-menu li.menu-item-has-children > a::before {
  inset-inline-start: 0;
  inset-inline-end: auto;
  content: "\f053";
}
.app-main-menu li {
  position: relative;
  list-style: none;
}
.app-main-menu li a {
  font-size: 14px;
  font-weight: 600;
  line-height: 1;
  color: rgba(255, 255, 255, 0.8);
  padding: 37px 5px;
  display: inline-block;
  letter-spacing: 0.2px;
}
.app-main-menu .dp-menu {
  background: var(--white);
  padding: 18px 0px;
  width: 260px;
  position: absolute;
  inset-inline-start: 0px;
  opacity: 0;
  pointer-events: none;
  z-index: 10;
  transition: all 0.3s;
  top: 100%;
  border-radius: 10px 10px;
  box-shadow: 0 10px 40px rgba(0, 0, 0, 0.08);
}
.app-main-menu .dp-menu ul {
  background: var(--white);
  padding: 18px 0px;
  width: 260px;
  position: absolute;
  inset-inline-start: calc(100% + 10px);
  top: 0;
  opacity: 0;
  z-index: 10;
  transition: all 0.3s;
  border-radius: 10px 10px;
  box-shadow: 0 10px 40px rgba(0, 0, 0, 0.08);
}
.app-main-menu .dp-menu li {
  position: relative;
  padding: 0 20px;
}
.app-main-menu .dp-menu li:hover > a {
  color: var(--secondary);
}
.app-main-menu .dp-menu li:hover > ul {
  opacity: 1;
  transform: none !important;
  pointer-events: all;
}
.app-main-menu .dp-menu li a {
  font-size: 15px;
  font-weight: 500;
  color: var(--heading);
  padding: 12px;
  display: block;
  transition: all 0.3s;
  text-align: left;
  cursor: pointer;
}
.app-main-menu .dp-menu li a i {
  margin-inline-end: 7px;
}
.app-main-menu .has-mega-menu {
  position: static;
}
.app-main-menu .mega-menu {
  background-color: var(--heading);
  padding: 30px 50px;
  width: 100%;
  position: absolute;
  inset-inline-start: -5px;
  display: grid;
  grid-template-columns: repeat(4, 1fr);
  column-gap: 50px;
  justify-content: center;
  overflow: hidden;
  opacity: 0;
  pointer-events: none;
  z-index: 10;
  transition: all 0.3s;
  top: 80px;
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .app-main-menu .mega-menu {
    column-gap: 30px;
  }
}
.app-main-menu .mega-menu li:has(ul) > a:after {
  content: "";
}
.app-main-menu .mega-menu li a {
  font-size: 16px;
  font-weight: 500;
  color: #999999;
  padding: 12px;
  display: block;
  align-items: center;
  gap: 8px;
  background: var(--heading);
  border-radius: 8px;
}
.app-main-menu .mega-menu li a:hover {
  color: var(--white);
  letter-spacing: 0.5px;
}
.app-main-menu .mega-menu .title {
  font-weight: 600;
  color: var(--white);
  text-transform: uppercase;
  border-bottom: 1px solid #333337;
  padding-bottom: 20px;
  margin-bottom: 20px;
  pointer-events: none;
  border-radius: 0;
}
.app-main-menu .mega-style-two {
  padding: 0 15%;
  gap: 0;
  grid-template-columns: repeat(2, 1fr);
}
.app-main-menu .mega-style-two .title {
  padding-top: 28px;
}
.app-main-menu .mega-style-two .title {
  height: 70px;
  padding-bottom: 0;
  margin-bottom: 0;
  position: relative;
  overflow: visible;
  padding-inline-start: 30px;
}
.app-main-menu .mega-style-two .title:after {
  position: absolute;
  content: "";
  width: 5000px;
  height: 1px;
  background-color: #333337;
  bottom: -1px;
  inset-inline-start: 50%;
  transform: translateX(-50%);
}
.app-main-menu .mega-style-two > li ul:not(:first-child) {
  border-inset-inline-start: 1px solid #333337;
}
.app-main-menu .mega-style-two ul {
  column-count: 2;
  position: relative;
  padding: 20px 0;
}
.app-main-menu .mega-style-two ul:after {
  position: absolute;
  content: "";
  width: 1px;
  height: 700px;
  background-color: #333337;
  top: 0;
  inset-inline-start: 50%;
  z-index: 1;
}
.app-main-menu .mega-style-two ul li a {
  padding-inline-start: 30px;
}
.app-main-menu .mega-style-three {
  padding: 0 0 0 20px;
  gap: 0;
  grid-template-columns: repeat(3, 1fr);
}
.app-main-menu .mega-style-three .title {
  padding-top: 28px;
}
.app-main-menu .mega-style-three .title {
  height: 70px;
  padding-bottom: 0;
  margin-bottom: 0;
  position: relative;
  overflow: visible;
  padding-inline-start: 30px;
}
.app-main-menu .mega-style-three .title:after {
  position: absolute;
  content: "";
  width: 5000px;
  height: 1px;
  background-color: #333337;
  bottom: -1px;
  inset-inline-start: 50%;
  transform: translateX(-50%);
}
.app-main-menu .mega-style-three > li:not(:first-child) {
  border-inset-inline-start: 1px solid #333337;
}
.app-main-menu .mega-style-three > li:last-child {
  border: none;
  width: 36vw;
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .app-main-menu .mega-style-three > li:last-child {
    width: 32vw;
  }
}
.app-main-menu .mega-style-three ul {
  column-count: 2;
  position: relative;
  padding: 20px 0;
  column-gap: 0;
}
.app-main-menu .mega-style-three ul:after {
  position: absolute;
  content: "";
  width: 1px;
  height: 700px;
  background-color: #333337;
  top: 0;
  inset-inline-start: 50%;
  z-index: 1;
}
.app-main-menu .mega-style-three ul li {
  margin: 0 10px;
}
.app-main-menu .mega-style-three ul li a {
  padding-inline-start: 20px;
}
.app-main-menu .mega-grid-six {
  grid-template-columns: repeat(6, 1fr);
  gap: 0 30px;
}
.app-main-menu .mega-grid-two {
  grid-template-columns: repeat(2, 1fr);
  row-gap: 60px;
}
.app-main-menu .list-three-column ul {
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  column-gap: 50px;
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .app-main-menu .list-three-column ul {
    column-gap: 30px;
  }
}
.app-main-menu .span-first-item ul li:first-child {
  grid-column: 1/-1;
  column-span: all;
}
.app-main-menu .new {
  font-size: 10px;
  font-weight: 600;
  background: #FFA38E;
  color: var(--heading);
  padding: 5px 8px 3px;
  line-height: 1;
  display: inline-block;
  border-radius: 2px;
}

.mega-menu-counter__item {
  text-align: center;
  display: inline-block;
  margin-top: 35%;
  margin-inline-start: 17%;
  position: relative;
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .mega-menu-counter__item {
    display: none;
  }
}
.mega-menu-counter__text p {
  font-size: 30px;
  line-height: 28px;
  color: var(--white);
  font-weight: 500;
}
.mega-menu-counter__number {
  font-size: 150px;
  font-weight: 600;
  line-height: 1;
  margin-bottom: 24px;
  color: var(--white);
  background: linear-gradient(136deg, #9479FF 0%, #FFA6D6 47.92%, #FFFCE3 100%);
  background-clip: text;
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}

.menu-icon {
  width: 26px;
  height: 20px;
  position: relative;
  display: block;
}
.menu-icon::before {
  position: absolute;
  content: "";
  width: 100%;
  height: 1px;
  top: 0;
  inset-inline-start: 0;
  background: var(--white);
  transition: all 0.3s;
}
.menu-icon::after {
  position: absolute;
  content: "";
  width: 100%;
  height: 1px;
  bottom: 0;
  inset-inline-start: 0;
  background: var(--white);
  transition: all 0.3s;
}
.menu-icon span {
  position: absolute;
  content: "";
  width: 18px;
  height: 1px;
  top: 50%;
  inset-inline-end: 0;
  transition: all 0.3s;
  background-color: var(--white);
}

/*----------------------------------------*/
/*  Meanmenu css
/*----------------------------------------*/
.mean-container {
  margin-bottom: 35px;
}
.mean-container a.meanmenu-reveal {
  width: 22px;
  height: 22px;
  padding: 13px 13px 11px 13px;
  position: absolute;
  top: 0;
  inset-inline-end: 0;
  cursor: pointer;
  color: var(--white);
  text-decoration: none;
  font-size: 16px;
  text-indent: -9999em;
  line-height: 22px;
  font-size: 1px;
  font-weight: 700;
  display: none !important;
}
.mean-container a.meanmenu-reveal span {
  display: block;
  background: var(--white);
  height: 3px;
  margin-top: 3px;
}
.mean-container .mean-push {
  float: left;
  width: 100%;
  padding: 0;
  margin: 0;
  clear: both;
}
.mean-container .mean-nav {
  background: none;
  margin-top: 0;
  float: left;
  width: 100%;
}
.mean-container .mean-nav .wrapper {
  width: 100%;
  padding: 0;
  margin: 0;
}
.mean-container .mean-nav > ul {
  padding: 0;
  margin: 0;
  width: 100%;
  list-style-type: none;
  display: block !important;
}
.mean-container .mean-nav > ul > li:first-child > a {
  border-top: 0 !important;
}
.mean-container .mean-nav ul {
  padding: 0;
  margin: 0;
  width: 100%;
  list-style-type: none;
}
.mean-container .mean-nav ul li {
  position: relative;
  float: left;
  width: 100%;
}
.mean-container .mean-nav ul li.dropdown-opened > a, .mean-container .mean-nav ul li.dropdown-opened > span {
  color: var(--white);
}
.mean-container .mean-nav ul li.dropdown-opened > a.mean-expand.mean-clicked, .mean-container .mean-nav ul li.dropdown-opened > span.mean-expand.mean-clicked {
  background: var(--white);
  color: var(--white);
  border-color: transparent;
}
.mean-container .mean-nav ul li.dropdown-opened > a.mean-expand.mean-clicked i, .mean-container .mean-nav ul li.dropdown-opened > span.mean-expand.mean-clicked i {
  color: var(--white);
  transform: rotate(90deg);
}
.mean-container .mean-nav ul li.mean-last {
  border-bottom: none;
  margin-bottom: 0;
}
.mean-container .mean-nav ul li > a.mean-expand i {
  display: inline-block;
  transition: 0.3s;
}
.mean-container .mean-nav ul li > a > i {
  display: none;
}
.mean-container .mean-nav ul li a, .mean-container .mean-nav ul li span {
  display: block;
  float: left;
  width: 90%;
  padding: 10px 5%;
  margin: 0;
  text-align: left;
  text-decoration: none;
  width: 100%;
  padding: 10px 0;
  color: var(--heading);
  border-top: 1px solid rgba(0, 0, 0, 0.1) !important;
  font-size: 16px;
  line-height: 1.5;
  font-weight: 500;
}
.mean-container .mean-nav ul li a:hover, .mean-container .mean-nav ul li span:hover {
  color: var(--primary);
}
.mean-container .mean-nav ul li a:hover i, .mean-container .mean-nav ul li span:hover i {
  color: var(--primary);
}
.mean-container .mean-nav ul li a.mean-expand, .mean-container .mean-nav ul li span.mean-expand {
  text-align: center;
  position: absolute;
  inset-inline-end: 0;
  top: 0;
  z-index: 2;
  font-weight: 700;
  background: transparent;
  border: none !important;
  font-size: 14px;
  margin-top: 5px;
  padding: 0 !important;
  border: 1px solid rgba(255, 255, 255, 0.079) !important;
  height: 30px;
  width: 30px;
  color: rgba(0, 0, 0, 0.6);
  line-height: 30px;
  top: 0;
  font-weight: 400;
}
.mean-container .mean-nav ul li a.mean-expand:hover, .mean-container .mean-nav ul li span.mean-expand:hover {
  background: var(--white);
  color: var(--white);
  border-color: var(--white);
}
.mean-container .mean-nav ul li a.mean-expand:hover i, .mean-container .mean-nav ul li span.mean-expand:hover i {
  color: var(--white);
}
.mean-container .mean-nav ul li a.mean-expand.mean-clicked, .mean-container .mean-nav ul li span.mean-expand.mean-clicked {
  color: var(--white);
}
.mean-container .mean-nav ul li a.mean-expand.mean-clicked:hover, .mean-container .mean-nav ul li span.mean-expand.mean-clicked:hover {
  background: var(--white);
  color: var(--white);
  border-color: var(--white);
}
.mean-container .mean-nav ul li li a {
  width: 90%;
  padding: 10px 7%;
  text-shadow: none !important;
  visibility: visible;
}
.mean-container .mean-nav ul li li li a {
  width: 80%;
  padding: 10px 12%;
}
.mean-container .mean-nav ul li li li li a {
  width: 70%;
  padding: 10px 17%;
}
.mean-container .mean-nav ul li li li li li a {
  width: 60%;
  padding: 10px 20%;
}
.mean-container .mean-bar {
  padding: 0;
  min-height: auto;
  background: none;
  float: left;
  width: 100%;
  position: relative;
  padding: 4px 0;
  min-height: 42px;
  z-index: 999999;
}
.mean-container .mean-bar, .mean-container .mean-bar * {
  /* Fix for box sizing on Foundation Framework etc. */
  -webkit-box-sizing: content-box;
  -moz-box-sizing: content-box;
  box-sizing: content-box;
}

/*----------------------------------------*/
/* Newsletter css
/*----------------------------------------*/
.app-newsletter-area {
  position: relative;
  z-index: 5;
}

.newsletter-main {
  padding: 60px 60px 65px;
  border-radius: 20px;
  background-color: var(--secondary);
  max-width: 1170px;
  margin: 0 auto;
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .newsletter-main {
    padding: 40px 50px;
  }
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .newsletter-main {
    padding: 30px 50px 35px;
  }
}
@media (max-width: 480px) {
  .newsletter-main {
    padding: 30px 20px 30px;
  }
}
.newsletter-main .newsletter-contents .title {
  font-size: 30px;
  color: var(--white);
  margin-bottom: 10px;
}
@media only screen and (min-width: 1200px) and (max-width: 1399px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .newsletter-main .newsletter-contents .title {
    font-size: 36px;
  }
}
@media only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .newsletter-main .newsletter-contents .title {
    font-size: 28px;
  }
}
@media (max-width: 575px) {
  .newsletter-main .newsletter-contents .title {
    font-size: 24px;
  }
}
.newsletter-main .newsletter-contents .description {
  color: rgba(255, 255, 255, 0.9);
  font-size: 16px;
}
.newsletter-main .newsletter-form {
  position: relative;
}
.newsletter-main .newsletter-form form {
  display: flex;
  align-items: center;
  gap: 10px 15px;
}
@media (max-width: 575px) {
  .newsletter-main .newsletter-form form {
    flex-direction: column;
  }
}
.newsletter-main .newsletter-form form input {
  backdrop-filter: blur(15px);
  background: #F9F9FB;
  border-radius: 16px;
  height: 60px;
  color: var(--black);
  border: 0;
  padding: 0 20px;
  font-size: 16px;
  font-weight: 500;
  padding-inline-end: 135px;
}
.newsletter-main .newsletter-form form input::-webkit-input-placeholder { /* Chrome/Opera/Safari */
  color: var(--black);
  font-size: 16px;
  font-weight: 500;
}
.newsletter-main .newsletter-form form input::-moz-placeholder { /* Firefox 19+ */
  color: var(--black);
  font-size: 16px;
  font-weight: 500;
}
.newsletter-main .newsletter-form form input:-moz-placeholder { /* Firefox 4-18 */
  color: var(--black);
  font-size: 16px;
  font-weight: 500;
}
.newsletter-main .newsletter-form form input:-ms-input-placeholder { /* IE 10+  Edge*/
  color: var(--black);
  font-size: 16px;
  font-weight: 500;
}
.newsletter-main .newsletter-form form input::placeholder { /* MODERN BROWSER */
  color: var(--black);
  font-size: 16px;
  font-weight: 500;
}
.newsletter-main .newsletter-form form .rockbank-btn.submit-btn {
  height: 45px;
  position: absolute;
  inset-inline-end: 8px;
  top: 50%;
  transform: translateY(-50%);
  background-color: var(--secondary);
  padding: 0 25px;
  border-radius: 10px;
}
@media (max-width: 575px) {
  .newsletter-main .newsletter-form form .rockbank-btn.submit-btn {
    position: inherit;
    transform: inherit;
    width: 100%;
  }
}

/*----------------------------------------*/
/* Price css
/*----------------------------------------*/
.pricing-item {
  background: var(--white);
  box-shadow: 0px 4px 20px rgba(0, 0, 0, 0.06);
  border-radius: 20px;
  padding: 30px 30px 30px;
  position: relative;
  z-index: 2;
}
.pricing-item::before {
  position: absolute;
  content: "";
  bottom: 0;
  inset-inline-start: 0;
  height: 70%;
  width: 100%;
  background-color: #F3FFF9;
  clip-path: polygon(0% 24.66%, 0% 24.66%, 0% 24.66%, 0.189% 22.31%, 0.735% 20.08%, 1.609% 18.001%, 2.782% 16.102%, 4.223% 14.414%, 5.903% 12.965%, 7.792% 11.787%, 9.86% 10.908%, 12.079% 10.359%, 14.417% 10.169%, 46.637% 10.169%, 69.956% 10.169%, 83.206% 10.169%, 83.206% 10.169%, 85.078% 10.076%, 86.914% 9.798%, 88.7% 9.344%, 90.426% 8.719%, 92.08% 7.93%, 93.649% 6.983%, 95.122% 5.884%, 96.488% 4.64%, 97.733% 3.258%, 98.847% 1.742%, 100% 0%, 100% 100%, 0% 100%, 0% 24.66%);
  z-index: -1;
}
.pricing-item::after {
  position: absolute;
  content: "";
  bottom: 1px;
  inset-inline-start: 0;
  height: 72%;
  width: 100%;
  background-color: #235F3E;
  clip-path: polygon(0% 22.458%, 0% 22.458%, 0% 22.458%, 0.162% 20.464%, 0.633% 18.574%, 1.386% 16.811%, 2.395% 15.2%, 3.636% 13.769%, 5.082% 12.54%, 6.708% 11.541%, 8.489% 10.796%, 10.399% 10.33%, 12.413% 10.169%, 83.122% 10.169%, 83.122% 10.169%, 85.008% 10.076%, 86.856% 9.799%, 88.654% 9.345%, 90.39% 8.721%, 92.053% 7.933%, 93.629% 6.988%, 95.108% 5.891%, 96.477% 4.65%, 97.723% 3.272%, 98.835% 1.761%, 100% 0%, 100% 100%, 0% 100%, 0% 22.458%);
  z-index: -2;
}
.pricing-item.plan-active {
  background-color: #235F3E;
}
.pricing-item.plan-active::after {
  background-color: rgba(255, 255, 255, 0.15);
}
.pricing-item.plan-active::before {
  background-color: var(--white);
}
.pricing-item.plan-active .item-title {
  color: var(--white);
}
.pricing-item.plan-active .price-value strong {
  color: var(--white);
}
.pricing-item.plan-active .price-value sub {
  color: rgba(255, 255, 255, 0.7);
}
.pricing-item.plan-active .rockbank-btn.price-btn {
  background-color: #235F3E;
  border-color: transparent;
  color: var(--white);
}
.pricing-item.plan-active .rockbank-btn.price-btn:hover {
  color: var(--white);
}
.pricing-item .price-icon {
  margin-bottom: 15px;
}
.pricing-item .list-item {
  display: flex;
  align-items: center;
  justify-content: space-between;
}
.pricing-item .list-item .list-content {
  display: flex;
  align-items: center;
}
.pricing-item .list-item .list-content .list-content_icon {
  padding-inline-end: 10px;
}
.pricing-item .list-item .list-content .list-content_icon i {
  font-size: 18px;
  color: #235F3E;
  position: relative;
  top: 2px;
}
.pricing-item .list-item .list-content .list-content-icon-text {
  font-size: 14px;
  font-weight: 500;
}
.pricing-item .list-item .list-content .list-content-text {
  font-size: 14px;
  font-weight: 600;
}
.pricing-item .item-title {
  color: rgba(28, 28, 30, 0.8);
  margin-bottom: 15px;
  font-size: 20px;
}
.pricing-item .price-value strong {
  font-size: 36px;
  color: var(--heading);
}
.pricing-item .price-value sub {
  bottom: 0;
}
.pricing-item .icon-list {
  margin-top: 60px;
  margin-bottom: 30px;
}
.pricing-item .icon-list li {
  list-style: none;
}
.pricing-item .icon-list li:not(:last-child) {
  margin-bottom: 15px;
}
.pricing-item .rockbank-btn.price-btn {
  border-radius: 15px;
  border: 1px solid #235F3E;
  color: #235F3E;
}
.pricing-item .rockbank-btn.price-btn:hover {
  background-color: #235F3E;
  border-color: transparent;
  color: var(--white);
}
.pricing-item .price-bottom .description {
  font-size: 12px;
  color: var(--secondary);
  text-align: center;
  margin-top: 15px;
}

.price-badge {
  padding: 7px 20px;
  background: var(--secondary);
  font-size: 14px;
  color: #FFFFFF;
  border-radius: 6px 6px 0px;
  position: absolute;
  inset-inline-end: -9px;
  top: 30px;
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .price-badge {
    font-size: 12px;
  }
}
.price-badge::before {
  position: absolute;
  content: "";
  bottom: -9px;
  inset-inline-end: 0px;
  border-top: 10px solid #C05105;
  border-inset-inline-end: 10px solid transparent;
}

/*----------------------------------------*/
/* video style
/*----------------------------------------*/
.rockbank-video-section {
  margin-bottom: 30px;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .rockbank-video-section {
    margin-bottom: 0;
  }
}

.rockbank-video-thumb {
  position: relative;
}
.rockbank-video-thumb img {
  background: rgba(255, 255, 255, 0.1);
  backdrop-filter: blur(4px);
  -webkit-border-radius: 20px;
  -moz-border-radius: 20px;
  -o-border-radius: 20px;
  -ms-border-radius: 20px;
  border-radius: 20px;
  width: 100%;
}
.rockbank-video-thumb .play-btn {
  width: 72px;
  height: 72px;
  display: -webkit-inline-box;
  display: -moz-inline-box;
  display: -ms-inline-flexbox;
  display: -webkit-inline-flex;
  display: inline-flexbox;
  display: inline-flex;
  align-items: center;
  justify-content: center;
  border-radius: 50%;
  background: rgba(255, 255, 255, 0.34);
  border: 1px solid rgba(255, 255, 255, 0.7);
  color: var(--warning);
  position: absolute;
  top: 50%;
  inset-inline-start: 50%;
  transform: translate(-50%, -50%);
}
.rockbank-video-thumb .play-btn::before {
  content: "";
  display: inline-block;
  width: 100%;
  height: 100%;
  border-radius: 50%;
  position: absolute;
  border: 1px solid rgba(255, 255, 255, 0.7);
  top: 0;
  inset-inline-start: 0;
  inset-inline-end: 0px;
  bottom: 0px;
  z-index: 0;
  animation-name: popupBtn;
  animation-duration: 1.6s;
  animation-timing-function: linear;
  animation-iteration-count: infinite;
  z-index: -1;
}
.rockbank-video-thumb .play-btn::after {
  content: "";
  display: inline-block;
  width: 100%;
  height: 100%;
  border-radius: 50%;
  position: absolute;
  border: 1px solid rgba(255, 255, 255, 0.7);
  top: 0;
  inset-inline-start: 0;
  inset-inline-end: 0;
  bottom: 0px;
  z-index: 0;
  animation-name: popupBtn;
  animation-duration: 1.8s;
  animation-timing-function: linear;
  animation-iteration-count: infinite;
  z-index: -1;
}

.profit-planning-video-box {
  position: relative;
}

.profit-planning-thumb {
  position: relative;
  border-radius: 15px;
  overflow: hidden;
}
.profit-planning-thumb img {
  width: 100%;
}
.profit-planning-thumb::before {
  position: absolute;
  content: "";
  height: 100%;
  width: 100%;
  background-color: rgba(0, 0, 0, 0.2);
  border-radius: 15px;
}

.planning-thumb-content {
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  display: flex;
  flex-direction: column;
  text-align: center;
  gap: 20px;
}
.planning-thumb-content .title {
  color: var(--white);
}
@media (max-width: 575px) {
  .planning-thumb-content .title {
    font-size: 20px;
  }
}

.play-btn {
  width: 116px;
  height: 116px;
  background: #FF5528;
  display: flex;
  align-items: center;
  justify-content: center;
  font-size: 26px;
  border-radius: 50%;
  animation: pulse 2s infinite;
  margin: 0 auto;
  color: var(--white);
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .play-btn {
    width: 85px;
    height: 85px;
  }
}
.play-btn:hover a {
  color: var(--white);
}
.play-btn:focus {
  color: var(--white);
}

.profit-planning-content-wrapper {
  background: rgba(255, 255, 255, 0.2);
  border: 1px solid rgba(255, 255, 255, 0.1);
  backdrop-filter: blur(20.5px);
  border-radius: 15px;
  padding: 45px 50px;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .profit-planning-content-wrapper {
    padding: 35px 30px;
  }
}
@media (max-width: 480px) {
  .profit-planning-content-wrapper {
    padding: 25px 20px;
  }
}
@media (max-width: 575px) {
  .profit-planning-content-wrapper .title {
    font-size: 20px;
  }
}

.profit-planning-form .app-single-input input {
  background: rgba(255, 255, 255, 0.2);
  border: 1px solid rgba(255, 255, 255, 0.5);
  box-shadow: 0px 4px 10px rgba(0, 101, 255, 0.04);
  color: var(--white);
  padding-inline-end: 70px;
}
.profit-planning-form .app-single-input input::-webkit-input-placeholder { /* Chrome/Opera/Safari */
  color: var(--white);
}
.profit-planning-form .app-single-input input::-moz-placeholder { /* Firefox 19+ */
  color: var(--white);
}
.profit-planning-form .app-single-input input:-moz-placeholder { /* Firefox 4-18 */
  color: var(--white);
}
.profit-planning-form .app-single-input input:-ms-input-placeholder { /* IE 10+  Edge*/
  color: var(--white);
}
.profit-planning-form .app-single-input input::placeholder { /* MODERN BROWSER */
  color: var(--white);
}

/*----------------------------------------*/
/* why choose style
/*----------------------------------------*/
.why-choose-shapes .shape-one {
  position: absolute;
  top: 0;
  inset-inline-start: 4%;
  z-index: -1;
}
.why-choose-shapes .shape-two {
  position: absolute;
  bottom: 7%;
  inset-inline-start: 26%;
  z-index: -1;
  -webkit-animation: tdZoom 4s infinite linear;
  animation: tdZoom 4s infinite linear;
  max-width: 65px;
}
@media only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .why-choose-shapes .shape-two {
    max-width: 60px;
  }
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px) {
  .why-choose-shapes .shape-two {
    display: none;
  }
}

.why-choose-content {
  background: var(--primary);
  padding: 45px 50px 45px 100px;
  position: absolute;
  inset-inline-start: 0;
  width: 41%;
}

.why-choose-content {
  background: var(--primary);
  padding: 45px 50px 45px 100px;
  position: absolute;
  inset-inline-start: 0;
  width: 31.3%;
  top: 50%;
  transform: translateY(-50%);
}
@media only screen and (min-width: 1400px) and (max-width: 1599px) {
  .why-choose-content {
    width: 36.3%;
  }
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .why-choose-content {
    padding: 45px 50px 45px 70px;
    width: 36.3%;
  }
}
@media only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .why-choose-content {
    padding: 45px 50px 45px 40px;
  }
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .why-choose-content {
    padding: 35px 30px 35px 30px;
  }
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .why-choose-content {
    position: inherit;
    transform: inherit;
    width: 100%;
  }
}
@media (max-width: 575px) {
  .why-choose-content {
    padding: 25px;
  }
}
.why-choose-content .section-title {
  color: var(--white);
}
.why-choose-content .description {
  color: var(--white);
}

.why-choose-grid {
  display: grid;
  gap: 40px 100px;
  grid-template-columns: repeat(2, 1fr);
}

.why-choose-item:not(:last-child) {
  padding-bottom: 40px;
  border-bottom: 2px solid rgba(35, 95, 62, 0.4);
}
.why-choose-item .icon {
  margin-bottom: 25px;
}
.why-choose-item .contents .title {
  font-size: 24px;
  margin-bottom: 25px;
  color: #235F3E;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px) {
  .why-choose-item .contents .title {
    font-size: 20px;
  }
}
.why-choose-item .contents .title a:hover {
  color: var(--secondary);
}

.why-choose-column {
  display: flex;
  flex-direction: column;
  gap: 40px;
  padding-top: 35px;
}
.why-choose-column:first-child {
  margin-top: 100px;
  padding-bottom: 70px;
}
@media (max-width: 575px) {
  .why-choose-column:first-child {
    margin-top: 0px;
    padding-bottom: 0px;
  }
}

.divider-line {
  width: 2px;
  display: inline-flex;
  background: rgba(35, 95, 62, 0.4);
}

.why-choose-grid {
  display: grid;
  gap: 40px 100px;
  grid-template-columns: 1fr 1px 1fr;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px), only screen and (min-width: 1200px) and (max-width: 1399px), only screen and (min-width: 1400px) and (max-width: 1599px) {
  .why-choose-grid {
    gap: 40px 40px;
  }
}
@media (max-width: 575px) {
  .why-choose-grid {
    grid-template-columns: 1fr;
    gap: 0;
  }
}

/*----------------------------------------*/
/* categories style
/*----------------------------------------*/
.categories-grid {
  display: grid;
  grid-template-columns: repeat(6, 1fr);
  gap: 30px;
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .categories-grid {
    grid-template-columns: repeat(4, 1fr);
  }
}
@media only screen and (min-width: 768px) and (max-width: 991px) {
  .categories-grid {
    grid-template-columns: repeat(3, 1fr);
  }
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px) {
  .categories-grid {
    grid-template-columns: repeat(2, 1fr);
  }
}
@media (max-width: 480px) {
  .categories-grid {
    grid-template-columns: 1fr;
  }
}
.categories-grid .category-item:nth-child(2n) {
  margin-top: 30px;
}

.category-item {
  padding: 50px 30px 45px;
  background: var(--white);
  box-shadow: 0px 4px 20px rgba(0, 101, 255, 0.08);
  border-radius: 30px;
  height: max-content;
  position: relative;
  overflow: hidden;
  display: block;
  z-index: 1;
}
@media only screen and (min-width: 1600px) and (max-width: 1800px), only screen and (min-width: 1400px) and (max-width: 1599px) {
  .category-item {
    padding: 45px 20px 45px;
  }
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .category-item {
    padding: 30px 20px 35px;
  }
}
.category-item .icon {
  margin-bottom: 28px;
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .category-item .icon {
    margin-bottom: 20px;
  }
}
.category-item .contents .title {
  margin-bottom: 18px;
  font-size: 20px;
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .category-item .contents .title {
    font-size: 16px;
  }
}
.category-item .contents .title a:hover {
  color: var(--primary);
}
.category-item .contents .description {
  font-size: 14px;
  font-weight: 500;
}
.category-item .category-shape {
  position: absolute;
  background-color: rgba(var(--primary), 0.2);
  width: 112px;
  height: 121.5px;
  clip-path: polygon(0% 99.18%, 35.253% 99.109%, 72.768% 99.59%, 99.949% 98.975%, 99.949% 75.582%, 100% 60.008%, 100% 29.357%, 100% 0%, 100% 0%, 99.923% 0.739%, 99.614% 2.841%, 98.955% 6.131%, 97.829% 10.434%, 96.117% 15.577%, 93.701% 21.385%, 90.464% 27.684%, 86.288% 34.3%, 81.056% 41.058%, 74.649% 47.785%, 74.649% 47.785%, 66.43% 54.535%, 57.332% 60.475%, 47.749% 65.774%, 38.071% 70.602%, 28.692% 75.128%, 20.004% 79.522%, 12.398% 83.955%, 6.267% 88.596%, 2.004% 93.614%, 0% 99.18%);
  bottom: -1px;
  inset-inline-end: 0;
  z-index: -1;
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .category-item .category-shape {
    width: 92px;
    height: 92px;
  }
}
[dir=rtl] .category-item .category-shape {
  bottom: -9px;
  transform: rotate(90deg);
}
.category-item:hover .category-shape {
  background-color: var(--primary);
}

/*----------------------------------------*/
/* Blog style
/*----------------------------------------*/
.blog-shapes .shape-one {
  position: absolute;
  top: 75px;
  inset-inline-start: 10%;
  z-index: -1;
}
.blog-shapes .shape-two {
  position: absolute;
  inset-inline-start: 10%;
  bottom: 20%;
  z-index: -1;
}
.blog-shapes .shape-three {
  position: absolute;
  inset-inline-end: 32px;
  top: 61px;
  z-index: -1;
}

.single-blog-item {
  position: relative;
}
.single-blog-item .blog-badge {
  position: absolute;
  top: 20px;
  inset-inline-start: 20px;
}
.single-blog-item .blog-badge .app-badge {
  padding: 9px 12px;
  background: rgba(0, 0, 0, 0.1);
  border: 1px solid rgba(255, 255, 255, 0.6);
  backdrop-filter: blur(15px);
  border-radius: 5px;
  color: var(--white);
}

.blog-thumb-inner {
  position: relative;
}
.blog-thumb-inner .blog-thumb {
  margin-bottom: 15px;
}
.blog-thumb-inner .blog-thumb img {
  border-radius: 30px;
  width: 100%;
}

.blog-meta-wrap {
  margin-bottom: 20px;
  display: flex;
  align-items: center;
  justify-content: space-between;
}

.blog-content .title {
  font-size: 20px;
  margin-bottom: 15px;
  color: var(--white);
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .blog-content .title {
    font-size: 18px;
  }
}
.blog-content .title a:hover {
  color: var(--white);
}
.blog-content .description {
  font-size: 14px;
  font-weight: 400;
}
.blog-content .user-meta {
  display: flex;
  align-items: center;
  gap: 10px;
  margin-bottom: 14px;
  flex-wrap: wrap;
}
.blog-content .user-meta span {
  background: var(--white);
  border-radius: 5px;
  padding: 5px 6px 4px 6px;
  display: flex;
  gap: 6px;
  align-items: center;
  justify-content: flex-start;
  position: relative;
  font-size: 12px;
  color: var(--secondary);
}

.blog-content-inner {
  border-radius: 20px;
  padding: 20px 20px;
  position: absolute;
  bottom: 24px;
  left: 50%;
  width: calc(100% - 40px);
  transform: translateX(-50%);
  background: rgba(0, 0, 0, 0.15);
  border: 2px solid rgba(255, 255, 255, 0.6);
  backdrop-filter: blur(27px);
}
@media (max-width: 575px) {
  .blog-content-inner {
    bottom: -20px;
  }
}

.blog-meta {
  display: flex;
  align-items: center;
  gap: 8px;
  margin-bottom: 10px;
}
.blog-meta .thumb {
  max-width: 20px;
  height: 20px;
  border: 1px solid var(--white);
  -webkit-border-radius: 50%;
  -moz-border-radius: 50%;
  -o-border-radius: 50%;
  -ms-border-radius: 50%;
  border-radius: 50%;
  display: inline-flex;
  flex: 0 0 auto;
}
.blog-meta .content h6,
.blog-meta .content span {
  font-size: 12px;
  font-weight: 500;
  color: var(--white);
}

/*----------------------------------------*/
/*  banner css
/*----------------------------------------*/
.app-banner-area.banner-style-one {
  padding: 140px 0px 80px;
  background-color: var(--primary);
}
@media only screen and (min-width: 1200px) and (max-width: 1399px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .app-banner-area.banner-style-one {
    padding: 120px 0px 60px;
  }
}
@media only screen and (min-width: 768px) and (max-width: 991px) {
  .app-banner-area.banner-style-one {
    padding: 120px 0px 80px;
  }
}
@media only screen and (min-width: 576px) and (max-width: 767px) {
  .app-banner-area.banner-style-one {
    padding: 130px 0px 60px;
  }
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px) {
  .app-banner-area.banner-style-one {
    padding: 130px 0px 60px;
  }
}
.app-banner-area.banner-style-one .banner-contents {
  margin-bottom: 45px;
}
.app-banner-area.banner-style-one .banner-contents .title {
  color: var(--white);
  margin-bottom: 25px;
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .app-banner-area.banner-style-one .banner-contents .title {
    font-size: 38px;
  }
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .app-banner-area.banner-style-one .banner-contents .title {
    font-size: 36px;
  }
}
.app-banner-area.banner-style-one .banner-contents .description {
  font-size: 20px;
  max-width: 534px;
  margin-bottom: 25px;
  color: var(--white);
}
@media only screen and (min-width: 1200px) and (max-width: 1399px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .app-banner-area.banner-style-one .banner-contents .description {
    font-size: 16px;
  }
}
@media only screen and (min-width: 768px) and (max-width: 991px) {
  .app-banner-area.banner-style-one .banner-contents .description {
    font-size: 18px;
  }
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px) {
  .app-banner-area.banner-style-one .banner-contents .description {
    font-size: 16px;
  }
}
.app-banner-area.banner-style-one .banner-contents .btn-inner {
  display: flex;
  align-items: center;
  gap: 16px;
  flex-wrap: wrap;
}
.app-banner-area.banner-style-one .banner-thumb {
  animation: upDown 1s infinite alternate;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .app-banner-area.banner-style-one .banner-thumb {
    max-width: 550px;
    margin: 0 auto;
  }
}
.app-banner-area.banner-style-one .banner-thumb img {
  width: 100%;
}
.app-banner-area.banner-style-one .banner-pattern-bg {
  position: absolute;
  top: 0;
  inset-inline-start: 0;
  width: 100%;
  height: 100%;
  background-repeat: no-repeat;
  background-size: cover;
  background-position: center;
  z-index: -1;
  opacity: 0.8;
}
.app-banner-area.banner-style-one .shape-one {
  position: absolute;
  top: 20%;
  inset-inline-start: 0;
}
[dir=rtl] .app-banner-area.banner-style-one .shape-one {
  transform: rotate(180deg);
}
@media only screen and (min-width: 992px) and (max-width: 1199px), only screen and (min-width: 1200px) and (max-width: 1399px) {
  .app-banner-area.banner-style-one .shape-one {
    max-width: 44px;
  }
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .app-banner-area.banner-style-one .shape-one {
    display: none;
  }
}
.app-banner-area.banner-style-one .shape-two {
  position: absolute;
  top: 20%;
  inset-inline-start: 10%;
  z-index: -1;
  -moz-animation: tpupdown 2.3s ease-in-out 2.3s forwards infinite alternate;
  -webkit-animation: tpupdown 2.3s ease-in-out 2.3s forwards infinite alternate;
  animation: tpupdown 2.3s ease-in-out 2.3s forwards infinite alternate;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .app-banner-area.banner-style-one .shape-two {
    display: none;
  }
}
.app-banner-area.banner-style-one .shape-three {
  position: absolute;
  bottom: 35%;
  inset-inline-start: 45%;
  z-index: -1;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .app-banner-area.banner-style-one .shape-three {
    display: none;
  }
}
.app-banner-area.banner-style-one .shape-four {
  position: absolute;
  bottom: 20%;
  inset-inline-start: 40%;
  z-index: -1;
  transform: translateX(-50%);
  animation: upslide 4s linear forwards infinite alternate;
  -webkit-animation: upslide 4s linear forwards infinite alternate;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .app-banner-area.banner-style-one .shape-four {
    max-width: 30px;
  }
}
.app-banner-area.banner-style-one .shape-five {
  position: absolute;
  top: 15%;
  inset-inline-end: 10%;
  z-index: -1;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .app-banner-area.banner-style-one .shape-five {
    display: none;
  }
}
.app-banner-area.banner-style-one .shape-six {
  position: absolute;
  inset-inline-end: 0;
  bottom: 53px;
  z-index: -1;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px), only screen and (min-width: 1200px) and (max-width: 1399px) {
  .app-banner-area.banner-style-one .shape-six {
    max-width: 50px;
  }
}
[dir=rtl] .app-banner-area.banner-style-one .shape-six {
  transform: rotate(180deg);
}
.app-banner-area.banner-style-one .banner-coin-one {
  position: absolute;
  top: 30%;
  inset-inline-start: 0;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .app-banner-area.banner-style-one .banner-coin-one {
    max-width: 60px;
  }
}
.app-banner-area.banner-style-one .banner-coin-two {
  position: absolute;
  inset-inline-start: 20%;
  top: 0;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .app-banner-area.banner-style-one .banner-coin-two {
    max-width: 60px;
  }
}
.app-banner-area.banner-style-one .banner-coin-three {
  position: absolute;
  top: 0;
  inset-inline-end: 0;
}
.app-banner-area.banner-style-one .banner-coin-four {
  position: absolute;
  bottom: 30%;
  inset-inline-end: 0;
}

.app-banner-area.banner-style-two {
  background-repeat: no-repeat;
  background-size: cover;
  background-position: bottom center;
  padding-top: 175px;
  padding-bottom: 150px;
}
@media only screen and (min-width: 1200px) and (max-width: 1399px), only screen and (min-width: 1400px) and (max-width: 1599px) {
  .app-banner-area.banner-style-two {
    padding-top: 125px;
  }
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .app-banner-area.banner-style-two {
    padding-top: 125px;
    padding-bottom: 120px;
  }
}
@media only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 576px) and (max-width: 767px) {
  .app-banner-area.banner-style-two {
    padding-top: 125px;
    padding-bottom: 150px;
  }
}
@media (max-width: 575px) {
  .app-banner-area.banner-style-two {
    padding-top: 100px;
    padding-bottom: 110px;
  }
}
.app-banner-area.banner-style-two .banner-contents .title {
  color: var(--white);
  margin-bottom: 15px;
}
.app-banner-area.banner-style-two .banner-contents .description {
  margin-bottom: 45px;
  max-width: 534px;
  color: var(--white);
}
.app-banner-area.banner-style-two .banner-contents .btn-inner {
  display: flex;
  align-items: center;
  gap: 16px;
  flex-wrap: wrap;
}
.app-banner-area.banner-style-two .banner-thumb-wrapper {
  position: relative;
}
.app-banner-area.banner-style-two .banner-thumb-wrapper .banner-thumb-one {
  position: relative;
}
.app-banner-area.banner-style-two .banner-thumb-wrapper .banner-thumb-one .thumb-mask {
  -webkit-mask-image: url(../images/banner/banner-two/mask.png);
  mask-image: url(../images/banner/banner-two/mask.png);
  -webkit-mask-repeat: no-repeat;
  mask-repeat: no-repeat;
  -webkit-mask-size: contain;
  margin-top: 45px;
  position: relative;
}
@media only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 576px) and (max-width: 767px) {
  .app-banner-area.banner-style-two .banner-thumb-wrapper .banner-thumb-one .thumb-mask {
    max-width: 450px;
  }
}
@media (max-width: 575px), sm {
  .app-banner-area.banner-style-two .banner-thumb-wrapper .banner-thumb-one .thumb-mask {
    max-width: 450px;
    margin: 0 auto;
  }
}
.app-banner-area.banner-style-two .banner-thumb-wrapper .banner-thumb-one .shape-hexagon {
  position: absolute;
  z-index: -1;
  left: -12px;
  top: -12px;
  width: 70%;
  height: 70%;
}
@media only screen and (min-width: 1400px) and (max-width: 1599px) {
  .app-banner-area.banner-style-two .banner-thumb-wrapper .banner-thumb-one .shape-hexagon {
    width: 85%;
    height: 100%;
  }
}
@media only screen and (min-width: 1200px) and (max-width: 1399px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .app-banner-area.banner-style-two .banner-thumb-wrapper .banner-thumb-one .shape-hexagon {
    width: 100%;
    height: 100%;
    inset-inline-start: -10px;
    top: -12px;
  }
}
@media only screen and (min-width: 768px) and (max-width: 991px) {
  .app-banner-area.banner-style-two .banner-thumb-wrapper .banner-thumb-one .shape-hexagon {
    position: absolute;
    z-index: -1;
    inset-inline-start: -18px;
    top: -20px;
    width: 70%;
    height: 70%;
  }
}
@media only screen and (min-width: 576px) and (max-width: 767px) {
  .app-banner-area.banner-style-two .banner-thumb-wrapper .banner-thumb-one .shape-hexagon {
    position: absolute;
    z-index: -1;
    inset-inline-start: -18px;
    top: -20px;
    width: 95%;
    height: 100%;
  }
}
@media (max-width: 575px) {
  .app-banner-area.banner-style-two .banner-thumb-wrapper .banner-thumb-one .shape-hexagon {
    inset-inline-start: 10px;
    top: -20px;
    width: calc(100% - 20px);
    height: calc(100% - 20px);
  }
}
.app-banner-area.banner-style-two .banner-thumb-wrapper .banner-thumb-two {
  margin-top: 45px;
  position: absolute;
  bottom: 0;
  inset-inline-end: 0;
}
[dir=rtl] .app-banner-area.banner-style-two .banner-thumb-wrapper .banner-thumb-two {
  inset-inline-end: auto;
  inset-inline-start: 0;
}
.app-banner-area.banner-style-two .banner-thumb-wrapper .banner-thumb-two .thumb-mask {
  -webkit-mask-image: url(../images/banner/banner-two/mask-02.png);
  mask-image: url(../images/banner/banner-two/mask-02.png);
  -webkit-mask-repeat: no-repeat;
  mask-repeat: no-repeat;
  -webkit-mask-size: contain;
  position: relative;
  z-index: 2;
}
@media (max-width: 575px) {
  .app-banner-area.banner-style-two .banner-thumb-wrapper .banner-thumb-two .thumb-mask {
    max-width: 200px;
  }
}
@media (max-width: 480px) {
  .app-banner-area.banner-style-two .banner-thumb-wrapper .banner-thumb-two .thumb-mask {
    max-width: 150px;
  }
}
.app-banner-area.banner-style-two .banner-thumb-wrapper .banner-thumb-two .shape-hexagon {
  position: absolute;
  z-index: -1;
  inset-inline-start: -10px;
  top: -10px;
  width: calc(100% + 20px);
  height: calc(100% + 20px);
}
.app-banner-area.banner-style-two .shape-one {
  position: absolute;
  bottom: 20%;
  inset-inline-end: 4%;
}
.app-banner-area.banner-style-two .shape-two {
  position: absolute;
  top: 20%;
  inset-inline-start: 10%;
  z-index: -1;
  -moz-animation: tpupdown 2.3s ease-in-out 2.3s forwards infinite alternate;
  -webkit-animation: tpupdown 2.3s ease-in-out 2.3s forwards infinite alternate;
  animation: tpupdown 2.3s ease-in-out 2.3s forwards infinite alternate;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .app-banner-area.banner-style-two .shape-two {
    display: none;
  }
}
.app-banner-area.banner-style-two .shape-three {
  position: absolute;
  bottom: 35%;
  inset-inline-start: 45%;
  z-index: -1;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .app-banner-area.banner-style-two .shape-three {
    display: none;
  }
}

/*----------------------------------------*/
/*  Header css
/*----------------------------------------*/
.header-transparent {
  position: absolute;
  inset-inline-start: 0;
  margin: auto;
  width: 100%;
  z-index: 99;
  background-color: transparent;
}

.header-primary {
  padding: 30px 30px;
}
@media (max-width: 575px) {
  .header-primary {
    padding: 20px 15px;
  }
}

@media (max-width: 575px) {
  .header-logo img {
    max-width: 120px;
  }
}

.header-lang-switcher {
  display: flex;
  align-items: center;
  gap: 15px;
}

.header-quick-action {
  display: flex;
  align-items: center;
  gap: 24px;
}
@media (max-width: 575px) {
  .header-quick-action {
    gap: 16px;
  }
}

.active-sticky {
  position: fixed !important;
  top: 0;
  z-index: 111;
  inset-inline-end: 0;
  inset-inline-start: 0;
  width: 100%;
  animation: sticky 0.3s;
  -webkit-animation: sticky 0.3s;
  z-index: 99;
  -webkit-box-shadow: 0px 4px 10px rgba(3, 4, 28, 0.1);
  box-shadow: 0px 4px 10px rgba(3, 4, 28, 0.1);
  background: var(--white);
}
.active-sticky .app-main-menu li a {
  color: var(--text-primary);
}
.active-sticky .header-lang-item > span {
  color: var(--text-primary);
}
.active-sticky .menu-icon::after, .active-sticky .menu-icon::before,
.active-sticky .menu-icon span {
  background-color: var(--black);
}

.header-lang-item {
  position: relative;
}
.header-lang-item > span {
  position: relative;
  font-size: 14px;
  transition: all 0.1s linear;
  z-index: 1;
  font-weight: 500;
  color: rgba(255, 255, 255, 0.8);
  display: inline-flex;
  align-items: center;
  gap: 5px;
}
.header-lang-item > span:hover {
  cursor: pointer;
}
.header-lang-item ul {
  position: absolute;
  top: calc(100% + 20px);
  inset-inline-start: 0;
  z-index: 33;
  padding: 10px 15px;
  visibility: hidden;
  opacity: 0;
  min-width: 150px;
  -webkit-transition: all 0.2s 0s ease-out;
  -moz-transition: all 0.2s 0s ease-out;
  -ms-transition: all 0.2s 0s ease-out;
  -o-transition: all 0.2s 0s ease-out;
  transition: all 0.2s 0s ease-out;
  background: var(--white);
  mix-blend-mode: normal;
  box-shadow: 0px 1px 3px rgba(3, 4, 28, 0.12);
  backdrop-filter: blur(50px);
  border-radius: 10px;
}
@media (max-width: 480px) {
  .header-lang-item ul {
    inset-inline-start: auto;
    inset-inline-end: 0;
  }
}
.header-lang-item ul.lang-list-open {
  visibility: visible;
  opacity: 1;
}
.header-lang-item ul li {
  list-style: none;
}
.header-lang-item ul li:not(:last-child) {
  margin-bottom: 3px;
}
.header-lang-item ul li span.icon {
  display: none;
  transition: none;
}
.header-lang-item ul li .active span.icon {
  display: inline-block;
}
.header-lang-item ul li a {
  font-size: 14px;
  font-weight: 500;
}
.header-lang-item ul li a:hover {
  color: var(--primary);
}

.header-lang-item {
  position: relative;
}
.header-lang-item > span {
  position: relative;
  font-size: 14px;
  transition: all 0.1s linear;
  z-index: 1;
  font-weight: 500;
  color: rgba(255, 255, 255, 0.8);
  display: inline-flex;
  align-items: center;
  gap: 5px;
}
.header-lang-item > span:hover {
  cursor: pointer;
}
.header-lang-item ul {
  position: absolute;
  top: calc(100% + 20px);
  inset-inline-end: 0;
  z-index: 33;
  padding: 10px 15px;
  visibility: hidden;
  opacity: 0;
  min-width: 150px;
  -webkit-transition: all 0.2s 0s ease-out;
  -moz-transition: all 0.2s 0s ease-out;
  -ms-transition: all 0.2s 0s ease-out;
  -o-transition: all 0.2s 0s ease-out;
  transition: all 0.2s 0s ease-out;
  background: var(--white);
  mix-blend-mode: normal;
  box-shadow: 0px 1px 3px rgba(3, 4, 28, 0.12);
  backdrop-filter: blur(50px);
  border-radius: 10px;
}
@media (max-width: 480px) {
  .header-lang-item ul {
    inset-inline-start: auto;
    inset-inline-end: 0;
  }
}
.header-lang-item ul.lang-list-open {
  visibility: visible;
  opacity: 1;
}
.header-lang-item ul li {
  list-style: none;
}
.header-lang-item ul li:not(:last-child) {
  margin-bottom: 3px;
}
.header-lang-item ul li span.icon {
  display: none;
  transition: none;
}
.header-lang-item ul li .active span.icon {
  display: inline-block;
}
.header-lang-item ul li a {
  font-size: 14px;
  font-weight: 500;
}
.header-lang-item ul li a:hover {
  color: var(--primary);
}

.header-style-one {
  z-index: 30;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .header-style-one {
    padding: 20px 0;
  }
}
.header-style-one.has-border-top {
  border-top: 1px solid rgba(255, 255, 255, 0.08);
}
.header-style-one .header-inner {
  display: flex;
  align-items: center;
  justify-content: space-between;
}
.header-style-one .header-inner .header-right {
  display: flex;
  align-items: center;
  gap: 35px;
}

.header-text-btn {
  font-weight: 800;
  color: #576363;
  display: -webkit-inline-box;
  display: -moz-inline-box;
  display: -ms-inline-flexbox;
  display: -webkit-inline-flex;
  display: inline-flexbox;
  display: inline-flex;
  align-items: center;
  gap: 8px;
  position: relative;
  font-size: 14px;
  color: var(--white);
  font-weight: 600;
}
.header-text-btn i {
  font-size: 18px;
}
.header-text-btn::after {
  position: absolute;
  content: "";
  width: calc(100% - 25px);
  height: 1px;
  bottom: -2px;
  inset-inline-end: 0;
  background-color: var(--white);
  transform: scaleX(1);
  transform-origin: bottom right;
  transition: transform 0.3s;
}
.header-text-btn:hover {
  color: var(--white);
}
.header-text-btn:hover::after {
  transform-origin: bottom left;
  transform: scaleX(0);
}
.header-text-btn:focus {
  color: var(--white);
}

.quick-access > ul {
  display: flex;
  align-items: center;
  gap: 10px;
}
.quick-access > ul > li {
  list-style: none;
}

.quick-access-item {
  width: 30px;
  height: 30px;
  display: inline-flex;
  align-items: center;
  justify-content: center;
  background: rgba(255, 255, 255, 0.1);
  border-radius: 50%;
  position: relative;
}
.quick-access-item .quick-access-count {
  position: absolute;
  width: 14px;
  height: 14px;
  background: #C70959;
  font-size: 8px;
  text-align: center;
  display: inline-flex;
  align-items: center;
  justify-content: center;
  border-radius: 50%;
  color: var(--white);
  top: -1px;
  inset-inline-end: 0px;
}
.quick-access-item .quick-access-btn {
  color: var(--white);
}
.quick-access-item .quick-access-user img {
  border: 1px solid var(--white);
  -webkit-border-radius: 50%;
  -moz-border-radius: 50%;
  -o-border-radius: 50%;
  -ms-border-radius: 50%;
  border-radius: 50%;
}

.app-user-menu-list-wrapper {
  min-width: 230px;
  background-color: var(--white);
  border-top: 1px solid rgba(230, 227, 241, 0.31);
  position: absolute;
  top: 200%;
  inset-inline-end: 0;
  visibility: hidden;
  clip: rect(0, 200vw, 0, 0);
  opacity: 0;
  transition: opacity 0.4s linear, clip 0.6s linear, visibility 0s 0.4s;
  transform: translateZ(0);
  z-index: 99;
  box-shadow: 4px 4px 20px rgba(0, 0, 0, 0.05);
}
.app-user-menu-list-wrapper .inner {
  padding: 20px 20px;
}
.app-user-menu-list-wrapper .inner .devider {
  margin-top: 10px;
  margin-bottom: 10px;
}

@media (max-width: 480px) {
  .quick-access {
    display: none;
  }
}

.quick-access-user {
  position: relative;
}
.quick-access-user:hover .app-user-menu-list-wrapper {
  visibility: visible;
  opacity: 1;
  clip: rect(0, 100vw, 200vh, -30px);
  transition: clip 0.6s linear, opacity 0.4s linear;
}

.app-admin-profile {
  display: flex;
  align-items: center;
  gap: 10px;
  padding-bottom: 10px;
  border-bottom: 1px solid rgba(0, 0, 0, 0.1);
  margin-bottom: 10px;
  text-align: start;
}
.app-admin-profile .title {
  font-size: 14px;
  font-weight: 600;
}
.app-admin-profile .info {
  font-size: 14px;
}
.app-admin-profile .info:hover {
  color: var(--primary);
}

.admin-thumbnail {
  max-width: 30px;
}

.user-list-wrapper.logout li a {
  color: #F34141;
}
.user-list-wrapper.logout li a i {
  transform: rotate(90deg);
}
.user-list-wrapper li {
  list-style: none;
  text-align: left;
}
.user-list-wrapper li:hover a {
  background-color: var(--primary);
}
.user-list-wrapper li a {
  display: flex;
  align-items: center;
  gap: 8px;
  padding: 5px 12px;
  align-items: center;
  border-radius: 3px;
}
.user-list-wrapper li a span {
  font-size: 14px;
}

.header-quick-action-item button {
  position: relative;
  top: 5px;
  color: var(--white);
}
.header-quick-action-item button .shopping-count {
  position: absolute;
  width: 16px;
  height: 16px;
  background: #09C711;
  font-size: 8px;
  text-align: center;
  display: inline-flex;
  align-items: center;
  justify-content: center;
  border-radius: 50%;
  color: var(--white);
  top: -7px;
  inset-inline-end: -7px;
}

.header-quick-action ul li {
  list-style: none;
}

.dark-icon,
.light-icon {
  cursor: pointer;
}

.dark-icon {
  display: none;
}

.dark-theme .dark-icon {
  display: block;
}
.dark-theme .primary .dark-icon {
  display: block;
}
.dark-theme .light-icon {
  display: none;
}

.notification-popup {
  margin-top: 25px !important;
  border: 0px;
  padding: 18px 20px 20px;
  background-color: var(--white);
  box-shadow: 0px 25px 70px rgba(8, 10, 55, 0.1);
  max-width: 400px;
}

.header-notifications > .title {
  font-size: 20px;
  margin-bottom: 20px;
}
.header-notifications .notifications-item-wrapper {
  height: 320px;
  overflow-y: scroll;
  padding-inline-end: 5px;
}
.header-notifications .notifications-item-wrapper::-webkit-scrollbar {
  width: 5px;
}
.header-notifications .notifications-item-wrapper::-webkit-scrollbar-thumb {
  border-radius: 10px;
  background: rgba(0, 0, 0, 0.2);
}
.header-notifications .notifications-item-wrapper::-webkit-scrollbar-track {
  border-radius: 10px;
  background: --white;
}
.header-notifications .notifications-item {
  padding: 10px 10px;
}
.header-notifications .notifications-item:hover {
  border-color: var(--primary);
}
.header-notifications .notifications-item:not(:last-child) {
  margin-bottom: 14px;
}
.header-notifications .notification-list {
  width: 90%;
}
.header-notifications .notification-list .content .title {
  font-size: 14px;
  margin-bottom: 8px;
  font-weight: 500;
  line-height: 1.5;
}
.header-notifications .notification-list .content .meta span {
  font-size: 12px;
}
.header-notifications .btn-wrap {
  margin-top: 20px;
}
.header-notifications .btn-wrap .site-btn.btn-xxs i {
  font-size: 20px !important;
}

.notifications-item {
  display: flex;
  justify-content: space-between;
  flex-wrap: wrap;
  gap: 10px 15px;
  background: #f4f6fd;
  border-radius: 6px;
  padding: 19px 20px;
}
.notifications-item:not(:last-child) {
  margin-bottom: 24px;
}

.notification-list {
  display: flex;
}
.notification-list .icon {
  height: 40px;
  width: 40px;
  border-radius: 50%;
  text-align: center;
  margin-inline-end: 15px;
  display: inline-flex;
  align-items: center;
  justify-content: center;
  font-size: 20px;
  flex: 0 0 auto;
}
.notification-list .content .title {
  font-size: 18px;
  margin-bottom: 6px;
}
.notification-list .content .title span {
  color: var(--primary);
}
.notification-list .content .meta {
  display: flex;
  gap: 20px;
}
.notification-list .content .meta span {
  font-size: 14px;
}
.notification-list .content .meta span:not(:first-child) {
  position: relative;
}
.notification-list .content .meta span:not(:first-child)::before {
  position: absolute;
  content: "";
  height: 5px;
  width: 5px;
  inset-inline-start: -12px;
  top: 50%;
  transform: translateY(-50%);
  background-color: var(--text-primary);
  border-radius: 50%;
}

.notifications-right-content {
  display: flex;
  align-items: center;
  gap: 10px 20px;
}
.notifications-right-content .status-icon {
  width: 6px;
  height: 6px;
  display: inline-flex;
  align-items: center;
  justify-content: center;
  background-color: var(--primary);
  border-radius: 50%;
}
.notifications-right-content .notifications-link .site-btn {
  background: rgba(86, 58, 239, 0.1);
  gap: 8px;
  color: rgb(86, 58, 239);
  font-weight: 600;
  font-size: 16px;
  border-radius: 6px;
  border: 0;
}
.notifications-right-content .notifications-link .site-btn:hover {
  background-color: var(--primary);
  color: var(--white);
}

/*----------------------------------------*/
/* Breadcrumb style
/*----------------------------------------*/
/*----------------------------------------*/
/*  Alerts Styles
/*----------------------------------------*/
.app-alert-success {
  background: rgba(22, 193, 19, 0.1);
  border-radius: 10px;
}
.app-alert-success .btn-close {
  background-size: 12px;
}
.app-alert-success .btn-close:focus {
  box-shadow: none;
}

.app-alert-danger {
  background: rgba(243, 65, 65, 0.1);
  border-radius: 10px;
}
.app-alert-danger .btn-close {
  background-size: 12px;
}
.app-alert-danger .btn-close:focus {
  box-shadow: none;
}

/*----------------------------------------*/
/*  2.12 Badge
/*----------------------------------------*/
.app-badge {
  font-size: 14px;
  font-weight: 500;
  text-transform: capitalize;
  display: inline-block;
  line-height: 1;
  text-align: center;
  position: relative;
  background-color: var(--white);
  padding: 9px 20px;
  color: var(--primary);
  border-radius: 8px;
}
.app-badge.primary {
  color: var(--primary);
  background-color: rgba(var(--primary), 0.2);
}
.app-badge.warning {
  color: var(--warning);
  background-color: rgba(255, 167, 57, 0.2);
}
.app-badge.danger {
  color: var(--danger);
  background-color: rgba(243, 65, 65, 0.2);
}
.app-badge.success {
  color: var(--success);
  background-color: rgba(22, 193, 19, 0.2);
}
.app-badge.black {
  color: var(--black);
  background-color: rgba(0, 0, 0, 0.2);
}
.app-badge.purple {
  background: rgba(107, 64, 234, 0.1);
  border-radius: 10px;
  color: var(--purple);
}

/*---------------------------------
/*  Button styles
---------------------------------*/
.btn-wrap {
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  align-items: center;
  gap: 15px 15px;
  flex-wrap: wrap;
}

.rockbank-btn {
  display: inline-flex;
  align-items: center;
  justify-content: center;
  height: 46px;
  color: var(--white);
  font-size: 16px;
  font-weight: 600;
  padding: 0 30px;
  gap: 5px;
}
.rockbank-btn.primary-btn {
  background-color: var(--primary);
}
.rockbank-btn.primary-btn:hover {
  background-color: var(--primary);
  color: var(--white);
}
.rockbank-btn.secondary-btn {
  background: var(--white);
  border: 1px solid var(--secondary);
  color: var(--secondary);
  padding: 0 30px;
}
.rockbank-btn.secondary-btn:hover {
  background-color: #FF5528;
  color: var(--white);
}
.rockbank-btn.white-btn {
  background-color: var(--white);
  color: var(--primary);
}
.rockbank-btn.orange-btn {
  background-color: var(--secondary);
}
.rockbank-btn.orange-btn:hover {
  background-color: #235F3E;
  color: var(--white);
}
.rockbank-btn.blue-btn {
  background-color: #136EF9;
}
.rockbank-btn.blue-btn:hover {
  color: var(--white);
}
.rockbank-btn.purple-btn {
  background-color: #6B40EA;
}
.rockbank-btn.purple-btn:hover {
  color: var(--white);
}
.rockbank-btn.success-btn {
  background-color: #16C113;
}
.rockbank-btn.success-btn:hover {
  color: var(--white);
}
.rockbank-btn.btn-fill {
  background-color: var(--primary);
  padding: 0 15px;
  border-radius: 10px;
}
.rockbank-btn.btn-fill:hover {
  color: var(--white);
}
.rockbank-btn.btn-xxs {
  height: 44px;
  padding: 0 20px;
  gap: 7px;
  font-size: 14px;
  font-weight: 500;
}
.rockbank-btn.btn-xxs i {
  font-size: 16px;
}
.rockbank-btn.btn-xs {
  height: 58px;
}

.text-link {
  font-weight: 500;
  font-size: 14px;
  color: var(--white);
  position: relative;
  display: inline-flex;
  align-items: center;
  gap: 8px;
}
.text-link::after {
  position: absolute;
  content: "";
  inset-inline-start: auto;
  inset-inline-end: 0;
  bottom: 4px;
  width: 0%;
  height: 1px;
  background-color: var(--white);
}
.text-link:hover {
  color: var(--white);
}
.text-link:hover::after {
  inset-inline-start: 0;
  inset-inline-end: auto;
  width: 100%;
}

.app-action-btn {
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  flex-direction: row;
  align-items: center;
  gap: 10px;
}
.app-action-btn .action-btn {
  font-size: 18px;
}
.app-action-btn .action-btn.orange-btn {
  color: var(--primary);
}
.app-action-btn .action-btn.warning-btn {
  color: var(--warning);
}

.app-dropdown .dropdown-toggle::after {
  content: "\e92b";
  font-family: "icomoon" !important;
  border: 0;
  font-size: 14px;
  transform: translateY(2px);
  margin-inline-start: 0;
}
.app-dropdown .dropdown-menu {
  background: var(--white);
  box-shadow: 4px 4px 20px rgba(0, 0, 0, 0.1);
  border: 0;
  padding: 12px 0px;
}
.app-dropdown .dropdown-item {
  font-size: 12px;
}
.app-dropdown .dropdown-item .dropdown-item:focus, .app-dropdown .dropdown-item .dropdown-item:hover {
  color: var(--primary);
  background-color: var(--primary);
}
.app-dropdown li:not(:last-child) {
  margin-bottom: 5px;
}

.app-action-fill-btn {
  border-radius: 9px !important;
  padding: 0 15px;
  color: var(--white);
  height: 38px;
  display: flex;
  align-items: center;
  justify-content: center;
  gap: 5px;
}
.app-action-fill-btn.orange-btn {
  background: var(--primary);
}
.app-action-fill-btn.white-btn {
  background: var(--white);
  box-shadow: 0px 4px 10px rgba(0, 101, 255, 0.04);
  border-radius: 5px;
  color: var(--primary);
}
.app-action-fill-btn.gray-btn {
  background: rgba(0, 101, 255, 0.1);
  border: 1px solid var(--white);
  box-shadow: 0px 4px 10px rgba(0, 101, 255, 0.04);
  border-radius: 5px;
  color: rgba(0, 0, 0, 0.6);
}

/*----------------------------------------*/
/*  Offcanvas
/*----------------------------------------*/
.offcanvas-area {
  background: #FFFFFF none repeat scroll 0 0;
  position: fixed;
  right: 0;
  top: 0;
  width: 340px;
  height: 100%;
  -webkit-transform: translateX(calc(100% + 80px));
  -moz-transform: translateX(calc(100% + 80px));
  -ms-transform: translateX(calc(100% + 80px));
  -o-transform: translateX(calc(100% + 80px));
  transform: translateX(calc(100% + 80px));
  -webkit-transition: transform 0.45s ease-in-out, opacity 0.45s ease-in-out;
  -moz-transition: transform 0.45s ease-in-out, opacity 0.45s ease-in-out;
  transition: transform 0.45s ease-in-out, opacity 0.45s ease-in-out;
  z-index: 999;
  overflow-y: scroll;
  overscroll-behavior-y: contain;
  scrollbar-width: none;
}
.offcanvas-area ::-webkit-scrollbar {
  display: none;
}
@media (max-width: 480px) {
  .offcanvas-area {
    width: 100%;
  }
}
.offcanvas-area.info-open {
  opacity: 1;
  transform: translateX(0);
}

.offcanvas-logo a img {
  width: 160px;
}
@media (max-width: 575px) {
  .offcanvas-logo a img {
    width: 150px;
  }
}
@media (max-width: 575px) {
  .offcanvas-logo a img {
    width: 140px;
  }
}

.offcanvas-content {
  padding-bottom: 45px;
}

.offcanva-wrapper {
  position: relative;
  height: 100%;
  padding: 30px 30px;
}

.offcanvas-top {
  padding-bottom: 25px;
  margin-bottom: 25px;
  border-bottom: 1px solid rgba(0, 0, 0, 0.1);
}

.offcanvas-title {
  color: var(--white);
  font-size: 20px;
  margin-bottom: 20px;
}
@media (max-width: 480px) {
  .offcanvas-title {
    font-size: 20px;
  }
}

.offcanva-wrapper p {
  margin-bottom: 25px;
}

.offcanvas-overlay {
  position: fixed;
  height: 100%;
  width: 100%;
  background: #000000;
  z-index: 900;
  top: 0;
  opacity: 0;
  visibility: hidden;
  inset-inline-end: 0;
  transition: 0.3s;
}
.offcanvas-overlay.overlay-open {
  opacity: 0.6;
  visibility: visible;
}

.sidebar-toggle {
  cursor: pointer;
}

.offcanvas-contact-icon {
  margin-inline-end: 15px;
}

.offcanvas-btn {
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  gap: 15px;
}
.offcanvas-btn .rockbank-btn {
  padding: 0 20px;
}

.offcanvas-close-icon {
  display: inline-flex;
  align-items: center;
  justify-content: center;
  font-size: 16px;
  height: 44px;
  width: 44px;
  line-height: 40px;
  border: 2px solid rgba(0, 0, 0, 0.1);
  background-color: transparent;
  border-radius: 50%;
}
.offcanvas-close-icon:hover {
  background-color: var(--primary);
  color: var(--white);
  border-color: transparent;
}

/*----------------------------------------*/
/* Section Title  
/*----------------------------------------*/
.section-subtitle {
  font-size: 20px;
  font-weight: 500;
  display: block;
  margin-bottom: 20px;
}
@media only screen and (min-width: 1200px) and (max-width: 1399px), only screen and (min-width: 992px) and (max-width: 1199px), only screen and (min-width: 768px) and (max-width: 991px) {
  .section-subtitle {
    font-size: 18px;
    margin-bottom: 15;
  }
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .section-subtitle {
    font-size: 16px;
    margin-bottom: 15;
  }
}

/*----------------------------------------*/
/* Tab customize
/*----------------------------------------*/
.app-tab .nav-tabs {
  padding: 0;
  margin: 0;
  border: 0;
}
.app-tab .nav-tabs .nav-link {
  padding: 0;
  margin: 0;
  border: 0;
  border-top-left-radius: 0;
  border-top-right-radius: 0;
}

/*----------------------------------------
   Basic pagination
-----------------------------------------*/
.pagination-wrapper {
  margin-top: 50px;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px) {
  .pagination-wrapper {
    margin-top: 30px;
  }
}

.app-pagination ul {
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  align-items: center;
  gap: 5px;
  flex-wrap: wrap;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .app-pagination ul {
    justify-content: start;
  }
}
.app-pagination ul li {
  list-style: none;
}
.app-pagination ul li a {
  width: 45px;
  height: 45px;
  display: -webkit-inline-box;
  display: -moz-inline-box;
  display: -ms-inline-flexbox;
  display: -webkit-inline-flex;
  display: inline-flexbox;
  display: inline-flex;
  align-items: center;
  justify-content: center;
  position: relative;
  inset-inline-end: 0;
  top: 50%;
  font-weight: 500;
  font-size: 18px;
  -webkit-border-radius: 12px;
  -moz-border-radius: 12px;
  -o-border-radius: 12px;
  -ms-border-radius: 12px;
  border-radius: 12px;
  background: var(--white);
  border: 1px solid #F1F1F1;
}
.app-pagination ul li a:hover {
  background-color: var(--primary);
  color: var(--white);
  border-color: var(--primary);
}
.app-pagination ul li a i {
  font-size: 14px;
}
.app-pagination ul li .current {
  width: 45px;
  height: 45px;
  display: -webkit-inline-box;
  display: -moz-inline-box;
  display: -ms-inline-flexbox;
  display: -webkit-inline-flex;
  display: inline-flexbox;
  display: inline-flex;
  align-items: center;
  justify-content: center;
  position: relative;
  inset-inline-end: 0;
  top: 50%;
  font-weight: 500;
  font-size: 16px;
  background-color: var(--primary);
  color: var(--white);
  border-color: var(--primary);
}

/*----------------------------------------*/
/* Back to top 
/*----------------------------------------*/
.backtotop-wrap {
  position: fixed;
  bottom: 30px;
  inset-inline-end: 30px;
  height: 46px;
  width: 46px;
  cursor: pointer;
  display: block;
  border-radius: 50px;
  z-index: 100;
  opacity: 0;
  visibility: hidden;
  transform: translateY(20px);
  -webkit-transition: all 400ms linear;
  -o-transition: all 400ms linear;
  transition: all 400ms linear;
  background: var(--secondary);
}
@media (max-width: 480px) {
  .backtotop-wrap {
    bottom: 20px;
    inset-inline-end: 20px;
  }
}
.backtotop-wrap.active-progress {
  opacity: 1;
  visibility: visible;
  transform: translateY(0px);
}
.backtotop-wrap::after {
  position: absolute;
  font-family: var(--ff-fontawesome);
  content: "\f062";
  text-align: center;
  line-height: 46px;
  font-size: 16px;
  font-weight: 400;
  color: var(--white);
  inset-inline-start: 0;
  top: 0;
  height: 46px;
  width: 46px;
  cursor: pointer;
  display: block;
  z-index: 1;
  -webkit-transition: all 400ms linear;
  -o-transition: all 400ms linear;
  transition: all 400ms linear;
}
.backtotop-wrap svg path {
  fill: none;
}
.backtotop-wrap svg.backtotop-circle path {
  stroke: #ccc;
  stroke-width: 0;
  -webkit-box-sizing: border-box;
  box-sizing: border-box;
  -webkit-transition: all 400ms linear;
  -o-transition: all 400ms linear;
  transition: all 400ms linear;
}

/*----------------------------------------*/
/*  forms scss
/*----------------------------------------*/
.app-single-input.has-right-icon .box-input {
  padding-inline-end: 45px;
}
.app-single-input.has-right-icon .input-icon {
  position: absolute;
  inset-inline-end: 15px;
  top: 50%;
  transform: translateY(-50%);
  font-size: 20px;
}
.app-single-input.has-right-icon .input-icon.eyeicon {
  cursor: pointer;
}
.app-single-input .input-field {
  position: relative;
}
.app-single-input .input-field.disabled input,
.app-single-input .input-field.disabled textarea {
  color: rgba(255, 255, 255, 0.5);
  cursor: not-allowed;
}
.app-single-input .input-field.disabled input:focus,
.app-single-input .input-field.disabled textarea:focus {
  border-color: rgba(255, 255, 255, 0.08);
}
.app-single-input .input-field .text-content {
  background: var(--white);
  box-shadow: 0px 4px 10px rgba(0, 101, 255, 0.04);
  border-radius: 5px;
  position: absolute;
  top: 50%;
  inset-inline-end: 5px;
  transform: translateY(-50%);
  padding: 5px 8px 6px;
  font-size: 14px;
  font-weight: 500;
  color: var(--primary);
}
.app-single-input .input-field input,
.app-single-input .input-field textarea {
  font-weight: 500;
}
.app-single-input .input-field textarea {
  padding: 12px 15px;
  height: 150px;
  resize: none;
}
.app-single-input .input-field textarea:focus {
  border-color: var(--primary);
}
.app-single-input .input-description {
  font-size: 12px;
  margin-top: 7px;
}
.app-single-input .input-label {
  font-size: 14px;
  margin-bottom: 7px;
  font-weight: 600;
  color: var(--white);
}
.app-single-input .input-label span {
  padding-inline-start: 4px;
  display: flex;
  align-items: center;
  gap: 6px;
}
.app-single-input .input-label-inner {
  display: flex;
  align-items: center;
  justify-content: space-between;
}
.app-single-input .input-label-inner > p {
  font-size: 12px;
}
.app-single-input .input-field.input-group {
  flex-wrap: nowrap;
}
.app-single-input .input-field .input-group-text {
  color: var(--white);
  background: rgba(255, 255, 255, 0.08);
  mix-blend-mode: normal;
  border: 1px solid rgba(255, 255, 255, 0.08);
  -webkit-border-radius: 12px;
  -moz-border-radius: 12px;
  -o-border-radius: 12px;
  -ms-border-radius: 12px;
  border-radius: 12px;
}
.app-single-input .input-select .nice-select {
  height: 44px;
  width: 100%;
  padding: 0 15px;
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  align-items: center;
  float: none;
  border: 1px solid rgba(255, 255, 255, 0.08);
  -webkit-border-radius: 12px;
  -moz-border-radius: 12px;
  -o-border-radius: 12px;
  -ms-border-radius: 12px;
  border-radius: 12px;
  background-color: rgba(255, 255, 255, 0.08);
}
.app-single-input .input-select .nice-select .current {
  text-align: left;
  font-size: 14px;
  position: relative;
  color: var(--white);
}
.app-single-input .input-select .nice-select .list {
  -webkit-transform: scale(1) translateY(0);
  -moz-transform: scale(1) translateY(0);
  -ms-transform: scale(1) translateY(0);
  -o-transform: scale(1) translateY(0);
  transform: scale(1) translateY(0);
  width: 100%;
  padding: 10px 0;
  -webkit-border-radius: 6px;
  -moz-border-radius: 6px;
  -o-border-radius: 6px;
  -ms-border-radius: 6px;
  border-radius: 6px;
  background: #242424;
  border-radius: 12px;
  border-style: solid;
  border-color: rgba(255, 255, 255, 0.08);
  border-width: 1px;
  padding: 12px 12px 12px 12px;
  max-height: 300px;
  overflow-y: scroll;
  -ms-overflow-style: none;
  /* IE and Edge */
  scrollbar-width: none;
  /* Firefox */
}
.app-single-input .input-select .nice-select::after {
  font-size: 16px;
  inset-inline-end: 16px;
  width: 8px;
  height: 8px;
  border-bottom: 1.5px solid var(--text-primary);
  border-inline-end: 1.5px solid var(--text-primary);
  font-size: 16px;
  content: "";
  position: absolute;
  top: 50%;
  transform: translateY(-50%) rotate(45deg);
  border: 5px solid;
  border-top-color: rgba(0, 0, 0, 0);
  border-left-color: rgba(0, 0, 0, 0);
  background-color: rgba(0, 0, 0, 0);
  transition: all ease-in-out 0.2s;
  margin-top: -2px;
  -webkit-border-radius: 2px;
  -moz-border-radius: 2px;
  -o-border-radius: 2px;
  -ms-border-radius: 2px;
  border-radius: 2px;
}
.app-single-input .input-select .nice-select .option {
  font-size: 14px;
  line-height: 38px;
  min-height: 38px;
  color: var(--white);
  border-radius: 10px;
  padding: 0 10px;
}
.app-single-input .input-select .nice-select .option.selected {
  font-weight: 500;
}
.app-single-input .input-select .nice-select .option:hover {
  background-color: #353535;
}
.app-single-input .input-select .nice-select .option.selected.focus {
  background-color: #353535;
}
.app-single-input .input-select .nice-select.open, .app-single-input .input-select .nice-select:focus {
  background-color: #353535;
}
.app-single-input.input-fill input {
  background: #EFF5FF;
  border: 1px solid rgba(0, 101, 255, 0.18);
  border-radius: 8px;
  height: 46px;
  font-size: 14px;
}
.app-single-input.input-fill input::-webkit-input-placeholder { /* Chrome/Opera/Safari */
  font-size: 14px;
}
.app-single-input.input-fill input::-moz-placeholder { /* Firefox 19+ */
  font-size: 14px;
}
.app-single-input.input-fill input:-moz-placeholder { /* Firefox 4-18 */
  font-size: 14px;
}
.app-single-input.input-fill input:-ms-input-placeholder { /* IE 10+  Edge*/
  font-size: 14px;
}
.app-single-input.input-fill input::placeholder { /* MODERN BROWSER */
  font-size: 14px;
}
.app-single-input .otp-verification {
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  gap: 20px 20px;
  flex-wrap: wrap;
  max-width: max-content;
  justify-content: center;
  margin: 0 auto;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .app-single-input .otp-verification {
    gap: 10px 10px;
  }
}
.app-single-input .otp-verification input {
  background: rgba(103, 107, 113, 0.1);
  height: 67px;
  width: 62px;
  text-align: center;
  font-size: 16px;
  font-weight: 500;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .app-single-input .otp-verification input {
    height: 55px;
    width: 50px;
  }
}
.app-single-input .otp-verification input:focus {
  background: rgba(0, 101, 255, 0.1);
}
.app-single-input.fill-white .input-field input {
  background: var(--white);
  box-shadow: 0px 4px 10px rgba(0, 101, 255, 0.04);
  border: 0;
  font-size: 14px;
  height: 46px;
  border-radius: 5px;
}
.app-single-input.fill-white .input-field input::-webkit-input-placeholder { /* Chrome/Opera/Safari */
  font-size: 14px;
}
.app-single-input.fill-white .input-field input::-moz-placeholder { /* Firefox 19+ */
  font-size: 14px;
}
.app-single-input.fill-white .input-field input:-moz-placeholder { /* Firefox 4-18 */
  font-size: 14px;
}
.app-single-input.fill-white .input-field input:-ms-input-placeholder { /* IE 10+  Edge*/
  font-size: 14px;
}
.app-single-input.fill-white .input-field input::placeholder { /* MODERN BROWSER */
  font-size: 14px;
}
.app-single-input.has-right-content {
  position: relative;
}
.app-single-input.has-right-content .input-badge {
  background: #FFFFFF;
  border-radius: 6px;
  padding: 6px 10px;
  position: absolute;
  inset-inline-end: 6px;
  top: 37px;
  font-size: 14px;
  font-weight: 600;
  color: var(--secondary);
}

.feedback-invalid {
  font-size: 12px;
  margin-top: 3px;
  color: #DC1D4B;
  display: none;
}

.input-attention {
  font-size: 12px;
  color: var(--danger);
}
.input-attention.xs {
  font-size: 10px;
}

/*----------------------------------------
   Image Preview 
-----------------------------------------*/
.file-upload-wrap .top-content {
  display: flex;
  justify-content: space-between;
  align-items: center;
  margin-bottom: 15px;
}
.file-upload-wrap .input-label {
  font-size: 14px;
  font-weight: 500;
  margin-bottom: 5px;
  color: #000000;
}

.upload-custom-file {
  position: relative;
  display: inline-block;
  width: 100%;
  height: 155px;
  text-align: center;
  border: 2px dashed var(--primary);
  border-radius: 8px;
}
.upload-custom-file input[type=file] {
  position: absolute;
  top: 0;
  inset-inline-start: 0;
  width: 2px;
  height: 2px;
  overflow: hidden;
  opacity: 0;
}
.upload-custom-file label {
  z-index: 1;
  position: absolute;
  inset-inline-start: 0;
  top: 0;
  bottom: 0;
  inset-inline-end: 0;
  width: 100%;
  overflow: hidden;
  cursor: pointer;
  border-radius: 8px;
  transition: transform 0.4s;
  display: flex;
  flex-direction: column;
  justify-content: center;
  text-align: center;
  -webkit-transition: -webkit-transform 0.4s;
  -moz-transition: -moz-transform 0.4s;
  -ms-transition: -ms-transform 0.4s;
  -o-transition: -o-transform 0.4s;
  transition: transform 0.4s;
}
.upload-custom-file label span {
  display: block;
  color: var(--text-primary);
  font-size: 14px;
  -webkit-transition: color 0.4s;
  -moz-transition: color 0.4s;
  -ms-transition: color 0.4s;
  -o-transition: color 0.4s;
  transition: color 0.4s;
}
.upload-custom-file label span b {
  color: var(--primary);
  font-weight: 500;
  text-decoration: underline;
}
.upload-custom-file label .type-file-text {
  margin-top: 5px;
  color: var(--danger);
}
.upload-custom-file label .upload-icon {
  width: 40px;
  margin: 0 auto;
  margin-bottom: 15px;
}
.upload-custom-file label.file-ok {
  background-repeat: no-repeat;
  background-position: center center;
  background-size: contain;
}
.upload-custom-file label.file-ok span {
  position: absolute;
  bottom: 0;
  inset-inline-start: 0;
  width: 100%;
  padding: 0.3rem;
  color: var(--white);
  background-color: rgba(1, 50, 41, 0.5);
  font-weight: 500;
  font-size: 16px;
  margin: auto;
  text-decoration: none;
}
.upload-custom-file label.file-ok .upload-icon {
  display: none;
}
.upload-custom-file.without-image {
  height: 176px;
}

.upload-thumb-close {
  position: absolute;
  inset-inline-end: 10px;
  top: 35px;
  z-index: 5;
  color: var(--danger);
  display: none;
}

.app-floating-input {
  position: relative;
}
.app-floating-input input:focus ~ .floating-label, .app-floating-input input:not(:focus):valid ~ .floating-label {
  top: 0;
  inset-inline-start: 20px;
  font-size: 14px;
  background-color: #f4f6fd;
  padding: 0px 4px;
  font-size: 14px;
}
.app-floating-input textarea:focus ~ .floating-label-2, .app-floating-input textarea:not(:focus):valid ~ .floating-label-2 {
  top: -9px;
  inset-inline-start: 20px;
  font-size: 14px;
  background-color: #f4f6fd;
  padding: 0px 4px;
}
.app-floating-input .floating-label {
  position: absolute;
  pointer-events: none;
  inset-inline-start: 20px;
  top: 50%;
  transform: translateY(-50%);
  transition: 0.2s ease all;
  font-size: 14px;
}
.app-floating-input .floating-label-2 {
  position: absolute;
  pointer-events: none;
  inset-inline-start: 20px;
  top: 14px;
  transition: 0.2s ease all;
  font-size: 14px;
}
.app-floating-input .inputText {
  border-radius: 10px;
  padding: 0px 20px;
  font-size: 14px;
  width: 100%;
  height: 46px;
  border: 0;
  outline: 0;
  font-weight: 500;
  border: 1px solid rgba(0, 0, 0, 0.1);
}
.app-floating-input .inputText:focus {
  border-color: var(--primary);
}
.app-floating-input .textareaText {
  border-radius: 12px;
  padding: 20px;
  font-size: 14px;
  width: 100%;
  height: 160px;
  resize: none;
  border: 0;
  outline: 0;
  border: 1px solid rgba(0, 0, 0, 0.1);
}
.app-floating-input .textareaText:focus {
  border-color: var(--primary);
}

.app-input-filter .nice-select {
  height: 46px;
  width: 100%;
  padding: 0 30px 0px 15px;
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  align-items: center;
  float: none;
  border: 1px solid rgba(255, 255, 255, 0.08);
  -webkit-border-radius: 8px;
  -moz-border-radius: 8px;
  -o-border-radius: 8px;
  -ms-border-radius: 8px;
  border-radius: 8px;
  background: rgba(255, 255, 255, 0.2);
  border: 1px solid rgba(255, 255, 255, 0.5);
  box-shadow: 0px 4px 10px rgba(0, 101, 255, 0.04);
  border-radius: 10px;
  color: var(--white);
}
.app-input-filter .nice-select .current {
  text-align: left;
  font-size: 14px;
  font-weight: 500;
  position: relative;
  color: var(--white);
}
@media (max-width: 480px) {
  .app-input-filter .nice-select .current {
    font-size: 12px;
  }
}
.app-input-filter .nice-select .list {
  -webkit-transform: scale(1) translateY(0);
  -moz-transform: scale(1) translateY(0);
  -ms-transform: scale(1) translateY(0);
  -o-transform: scale(1) translateY(0);
  transform: scale(1) translateY(0);
  width: max-content;
  padding: 10px 0;
  -webkit-border-radius: 6px;
  -moz-border-radius: 6px;
  -o-border-radius: 6px;
  -ms-border-radius: 6px;
  border-radius: 6px;
  border-radius: 12px;
  padding: 12px 12px 12px 12px;
  max-height: 300px;
  width: 100%;
  overflow-y: scroll;
  -ms-overflow-style: none;
  /* IE and Edge */
  scrollbar-width: none;
  /* Firefox */
  background: var(--white);
  -webkit-box-shadow: 4px 4px 20px rgba(0, 0, 0, 0.1);
  -moz-box-shadow: 4px 4px 20px rgba(0, 0, 0, 0.1);
  -ms-box-shadow: 4px 4px 20px rgba(0, 0, 0, 0.1);
  -o-box-shadow: 4px 4px 20px rgba(0, 0, 0, 0.1);
  box-shadow: 4px 4px 20px rgba(0, 0, 0, 0.1);
  z-index: 30;
  z-index: 30;
  background: #38434f;
  border: 1px solid rgba(255, 255, 255, 0.1);
  backdrop-filter: blur(20px);
}
.app-input-filter .nice-select::after {
  inset-inline-end: 16px;
  width: 9px;
  height: 9px;
  font-size: 16px;
  content: "";
  position: absolute;
  top: 50%;
  border-color: var(--white);
  -webkit-border-radius: 2px;
  -moz-border-radius: 2px;
  -o-border-radius: 2px;
  -ms-border-radius: 2px;
  border-radius: 2px;
}
[dir=rtl] .app-input-filter .nice-select::after {
  inset-inline: auto;
  inset-inline-end: 12px;
}
.app-input-filter .nice-select .option {
  font-size: 14px;
  line-height: 40px;
  min-height: 40px;
  color: var(--white);
  border-radius: 10px;
  padding: 0 15px;
}
[dir=rtl] .app-input-filter .nice-select .option {
  text-align: right;
}
.app-input-filter .nice-select .option.selected {
  font-weight: 500;
}
.app-input-filter .nice-select .option:hover {
  background-color: var(--white);
  color: var(--text-primary);
}
.app-input-filter .nice-select .option.selected.focus {
  background-color: var(--white);
  color: var(--text-primary);
}
.app-input-filter.input-xxs .nice-select {
  height: 38px;
  font-size: 14px;
  min-width: 155px;
}
.app-input-filter.input-xxs .nice-select::after {
  width: 8px;
  height: 8px;
}
.app-input-filter.input-xxs .nice-select .option {
  line-height: 35px;
  min-height: 35px;
}

.input-label {
  font-size: 14px;
  margin-bottom: 5px;
}

/*----------------------------------------*/
/*  Animations 
/*----------------------------------------*/
@keyframes popupBtn {
  0% {
    transform: scale(1);
    opacity: 0.6;
  }
  50% {
    transform: scale(1.4);
    opacity: 0.3;
  }
  100% {
    transform: scale(2);
    opacity: 0;
  }
}
@keyframes sticky {
  0% {
    transform: translateY(-100%);
  }
  100% {
    transform: translateY(0%);
  }
}
@keyframes pulse {
  0% {
    -moz-box-shadow: 0 0 0 0 rgba(255, 255, 255, 0.4);
    box-shadow: 0 0 0 0 rgba(255, 255, 255, 0.4);
  }
  70% {
    -moz-box-shadow: 0 0 0 45px rgba(255, 255, 255, 0);
    box-shadow: 0 0 0 45px rgba(255, 255, 255, 0);
  }
  100% {
    -moz-box-shadow: 0 0 0 0 rgba(255, 255, 255, 0);
    box-shadow: 0 0 0 0 rgba(255, 255, 255, 0);
  }
}
@keyframes upslide {
  0%, 20%, 50%, 80%, 100% {
    transform: translateY(0);
  }
  40% {
    transform: translateY(-20px);
  }
  60% {
    transform: translateY(-10px);
  }
}
@keyframes tdZoom {
  0% {
    scale: 1;
  }
  50% {
    scale: 0.5;
  }
  100% {
    scale: 1;
  }
}
@keyframes apSpinner {
  from {
    -webkit-transform: rotate(0turn);
    transform: rotate(0turn);
  }
  to {
    -webkit-transform: rotate(1turn);
    transform: rotate(1turn);
  }
}
@-webkit-keyframes tpupdown {
  0% {
    -webkit-transform: translateY(0);
    -moz-transform: translateY(0);
    -ms-transform: translateY(0);
    -o-transform: translateY(0);
    transform: translateY(0);
  }
  100% {
    -webkit-transform: translateY(-20px);
    -moz-transform: translateY(-20px);
    -ms-transform: translateY(-20px);
    -o-transform: translateY(-20px);
    transform: translateY(-20px);
  }
}
@-moz-keyframes tpupdown {
  0% {
    -webkit-transform: translateY(0);
    -moz-transform: translateY(0);
    -ms-transform: translateY(0);
    -o-transform: translateY(0);
    transform: translateY(0);
  }
  100% {
    -webkit-transform: translateY(-20px);
    -moz-transform: translateY(-20px);
    -ms-transform: translateY(-20px);
    -o-transform: translateY(-20px);
    transform: translateY(-20px);
  }
}
@-ms-keyframes tpupdown {
  0% {
    -webkit-transform: translateY(0);
    -moz-transform: translateY(0);
    -ms-transform: translateY(0);
    -o-transform: translateY(0);
    transform: translateY(0);
  }
  100% {
    -webkit-transform: translateY(-20px);
    -moz-transform: translateY(-20px);
    -ms-transform: translateY(-20px);
    -o-transform: translateY(-20px);
    transform: translateY(-20px);
  }
}
@keyframes tpupdown {
  0% {
    -webkit-transform: translateY(0);
    -moz-transform: translateY(0);
    -ms-transform: translateY(0);
    -o-transform: translateY(0);
    transform: translateY(0);
  }
  100% {
    -webkit-transform: translateY(-20px);
    -moz-transform: translateY(-20px);
    -ms-transform: translateY(-20px);
    -o-transform: translateY(-20px);
    transform: translateY(-20px);
  }
}
@keyframes upDown {
  0% {
    transform: translateY(0);
  }
  100% {
    transform: translateY(-15px);
  }
}
@keyframes eduvibe-rotate-x {
  0% {
    -webkit-transform: rotate(0deg);
    transform: rotate(0deg);
  }
  100% {
    -webkit-transform: rotate(360deg);
    transform: rotate(360deg);
  }
}
/*----------------------------------------*/
/*  Shortcodes
/*----------------------------------------*/
.text-body {
  color: var(--text-primary) !important;
}

.text-white {
  color: var(--white);
}

.text-black {
  color: var(--black);
}

.text-primary {
  color: var(--primary);
}

.text-secondary {
  color: var(--secondary);
}

.text-quaternary {
  color: var(--secondary);
}

.text-gradient-1 {
  background: linear-gradient(135deg, rgba(253, 216, 25, 0.5) 0%, rgba(248, 23, 23, 0.5) 100%);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
  background-clip: text;
  text-fill-color: transparent;
}

.radius-4 {
  -webkit-border-radius: 4px;
  -moz-border-radius: 4px;
  -o-border-radius: 4px;
  -ms-border-radius: 4px;
  border-radius: 4px;
}

.radius-6 {
  -webkit-border-radius: 6px;
  -moz-border-radius: 6px;
  -o-border-radius: 6px;
  -ms-border-radius: 6px;
  border-radius: 6px;
}

.radius-8 {
  -webkit-border-radius: 8px;
  -moz-border-radius: 8px;
  -o-border-radius: 8px;
  -ms-border-radius: 8px;
  border-radius: 8px;
}

.radius-10 {
  -webkit-border-radius: 10px;
  -moz-border-radius: 10px;
  -o-border-radius: 10px;
  -ms-border-radius: 10px;
  border-radius: 10px;
}

.radius-12 {
  -webkit-border-radius: 12px;
  -moz-border-radius: 12px;
  -o-border-radius: 12px;
  -ms-border-radius: 12px;
  border-radius: 12px;
}

.radius-14 {
  -webkit-border-radius: 14px;
  -moz-border-radius: 14px;
  -o-border-radius: 14px;
  -ms-border-radius: 14px;
  border-radius: 14px;
}

.radius-16 {
  -webkit-border-radius: 16px;
  -moz-border-radius: 16px;
  -o-border-radius: 16px;
  -ms-border-radius: 16px;
  border-radius: 16px;
}

.radius-18 {
  -webkit-border-radius: 18px;
  -moz-border-radius: 18px;
  -o-border-radius: 18px;
  -ms-border-radius: 18px;
  border-radius: 18px;
}

.radius-20 {
  -webkit-border-radius: 20px;
  -moz-border-radius: 20px;
  -o-border-radius: 20px;
  -ms-border-radius: 20px;
  border-radius: 20px;
}

.radius-30 {
  -webkit-border-radius: 30px;
  -moz-border-radius: 30px;
  -o-border-radius: 30px;
  -ms-border-radius: 30px;
  border-radius: 30px;
}

.radius-40 {
  -webkit-border-radius: 40px;
  -moz-border-radius: 40px;
  -o-border-radius: 40px;
  -ms-border-radius: 40px;
  border-radius: 40px;
}

.radius-45 {
  -webkit-border-radius: 45px;
  -moz-border-radius: 45px;
  -o-border-radius: 45px;
  -ms-border-radius: 45px;
  border-radius: 45px;
}

.radius-50 {
  -webkit-border-radius: 50px;
  -moz-border-radius: 50px;
  -o-border-radius: 50px;
  -ms-border-radius: 50px;
  border-radius: 50px;
}

.radius-60 {
  -webkit-border-radius: 60px;
  -moz-border-radius: 60px;
  -o-border-radius: 60px;
  -ms-border-radius: 60px;
  border-radius: 60px;
}

.title-font {
  font-family: var(--ff-title);
}

.fw-3 {
  font-weight: var(--fw-light);
}

.fw-4 {
  font-weight: var(--fw-regular);
}

.fw-5 {
  font-weight: var(--fw-medium);
}

.fw-6 {
  font-weight: var(--fw-sbold);
}

.fw-7 {
  font-weight: var(--fw-bold);
}

.fw-8 {
  font-weight: var(--fw-ebold);
}

.fw-9 {
  font-weight: var(--fw-black);
}

.fs-3 {
  font-size: 3px;
}

.fs-4 {
  font-size: 4px;
}

.fs-5 {
  font-size: 5px;
}

.fs-6 {
  font-size: 6px;
}

.fs-7 {
  font-size: 7px;
}

.fs-8 {
  font-size: 8px;
}

.fs-9 {
  font-size: 9px;
}

.fs-10 {
  font-size: 10px;
}

.fs-11 {
  font-size: 11px;
}

.fs-12 {
  font-size: 12px;
}

.fs-13 {
  font-size: 13px;
}

.fs-14 {
  font-size: 14px;
}

.gap--5 {
  gap: 5px;
}

.gap-10 {
  gap: 10px;
}

.gap-15 {
  gap: 15px;
}

.gap-20 {
  gap: 20px;
}

.gap-24 {
  gap: 24px;
}

.hide {
  opacity: 0;
  transition: opacity 0.5s ease-out;
}

/*----------------------------------------*/
/*  Background Css
/*----------------------------------------*/
.white-bg {
  background-color: var(--white);
}

.black-bg {
  background-color: var(--black);
}

.theme-bg {
  background-color: var(--primary);
}

.laundry-white-bg {
  background-color: var(--laundry-white);
}

/*----------------------------------------*/
/*  Preloader scss
/*----------------------------------------*/
#preloader {
  position: fixed;
  width: 100%;
  height: 100%;
  inset-inline-start: 0;
  top: 0;
  background-color: var(--white);
  z-index: 999;
}

.sk-three-bounce {
  margin: 0;
  width: 100%;
  height: 100%;
  text-align: center;
  background-color: var(--white);
}
.sk-three-bounce .sk-child {
  position: relative;
  top: 50%;
  transform: translateY(-50%);
  width: 20px;
  height: 20px;
  background-color: var(--secondary);
  border-radius: 100%;
  display: inline-block;
  -webkit-animation: sk-three-bounce 1.4s ease-in-out 0s infinite both;
  animation: sk-three-bounce 1.4s ease-in-out 0s infinite both;
}
.sk-three-bounce .sk-bounce1 {
  -webkit-animation-delay: -0.32s;
  animation-delay: -0.32s;
}
.sk-three-bounce .sk-bounce2 {
  -webkit-animation-delay: -0.16s;
  animation-delay: -0.16s;
}

@-webkit-keyframes sk-three-bounce {
  0%, 80%, 100% {
    -webkit-transform: scale(0);
    transform: scale(0);
  }
  40% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }
}
@keyframes sk-three-bounce {
  0%, 80%, 100% {
    -webkit-transform: scale(0);
    transform: scale(0);
  }
  40% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }
}
/*----------------------------------------*/
/*  Colors
/*----------------------------------------*/
.white-text {
  color: var(--white) !important;
}

.black-text {
  color: var(--black);
}

.heading-text {
  color: var(--heading);
}

.theme-secondary {
  color: var(--secondary);
}

.theme-text-primary {
  color: var(--text-secondary);
}

.theme-text-secondary {
  color: var(--text-secondary);
}

.warning-text {
  color: var(--warning);
}

.success-text {
  color: var(--success);
}

.danger-text {
  color: var(--danger);
}

.green-text {
  color: var(--green);
}

/*----------------------------------------*/
/* site table
/*----------------------------------------*/
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .rockbank-custom-table {
    min-width: 1100px;
  }
}
.rockbank-custom-table .contents {
  display: table;
  width: 100%;
}
.rockbank-custom-table .contents .site-table-head .custom-table-col {
  padding: 16px 0px;
  font-size: 12px !important;
  font-weight: 400;
  color: var(--heading);
  background: rgba(143, 148, 255, 0.1);
  -webkit-box-shadow: 4px;
  -moz-box-shadow: 4px;
  -ms-box-shadow: 4px;
  -o-box-shadow: 4px;
  box-shadow: 4px;
  border-bottom: 1px solid rgba(255, 255, 255, 0.1);
  border-top: 1px solid rgba(255, 255, 255, 0.1);
  background: #F9FAFB;
}
.rockbank-custom-table .contents .site-table-head .custom-table-col:first-child {
  padding-inline-start: 20px;
  border-start-start-radius: 20px;
  border-end-start-radius: 20px;
  border-inline-start: 1px solid rgba(0, 0, 0, 0.07);
}
.rockbank-custom-table .contents .site-table-head .custom-table-col:last-child {
  border-end-end-radius: 20px;
  border-top-right-radius: 20px;
  padding-inline-end: 20px;
  border-inline-end: 1px solid rgba(0, 0, 0, 0.07);
  text-align: end;
}
.rockbank-custom-table .contents .custom-table-table-list {
  display: table-row;
}
.rockbank-custom-table .contents .custom-table-table-list .custom-table-col {
  position: relative;
  display: table-cell;
  font-size: 14px;
  font-weight: 600;
  vertical-align: middle;
  padding: 18px 0.5rem 18px 0px;
  border-bottom: 1px solid rgba(0, 0, 0, 0.1) !important;
}
.rockbank-custom-table .contents .custom-table-table-list .custom-table-col:last-child {
  text-align: end;
}
.rockbank-custom-table .contents .custom-table-table-list .custom-table-col .description {
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  align-items: center;
  gap: 11px;
}
.rockbank-custom-table .contents .custom-table-table-list .custom-table-col .description .content .title {
  margin-bottom: 3px;
  font-size: 14px;
  font-weight: 700;
}
.rockbank-custom-table .contents .custom-table-table-list .custom-table-col .description .content .title a:hover {
  color: var(--primary);
}
.rockbank-custom-table .contents .custom-table-table-list .custom-table-col .description .content .description {
  font-size: 11px;
  margin-bottom: 0;
}
.rockbank-custom-table .contents .custom-table-table-list .custom-table-col .action {
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  flex-direction: row;
  align-items: center;
}
.rockbank-custom-table .contents .custom-table-table-list .custom-table-col .action span {
  margin-inline-start: 5px;
}
.rockbank-custom-table .contents .custom-table-table-list:last-child .custom-table-col {
  border-bottom: 0;
}

.transactions-description {
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  align-items: center;
  gap: 8px;
}
.transactions-description .content .title {
  margin-bottom: 5px;
  font-size: 14px;
  font-weight: 600;
}
.transactions-description .content .description {
  font-size: 12px;
}

/*----------------------------------------*/
/* Dashboard css 
/*----------------------------------------*/
.app-dashboard-card {
  padding: 30px;
  background: var(--white);
  border-radius: 10px;
  -webkit-border-radius: 12px;
  -moz-border-radius: 12px;
  -o-border-radius: 12px;
  -ms-border-radius: 12px;
  border-radius: 12px;
}
@media (max-width: 480px) {
  .app-dashboard-card {
    padding: 18px;
  }
}

.app-dashboard-title-inner {
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  align-items: center;
  justify-content: space-between;
  margin-bottom: 25px;
  flex-wrap: wrap;
  gap: 20px 10px;
}
@media (max-width: 575px) {
  .app-dashboard-title-inner {
    margin-bottom: 20px;
    flex-wrap: wrap;
    gap: 20px 10px;
    border-bottom: 1px solid rgba(255, 255, 255, 0.1);
  }
}
.app-dashboard-title-inner .description {
  font-size: 14px;
  font-weight: 400;
  margin-top: 5px;
}
@media (max-width: 575px) {
  .app-dashboard-title-inner .description {
    font-size: 12px;
  }
}
@media (max-width: 575px) {
  .app-dashboard-title-inner .site-btn.gradient-btn {
    height: 32px;
    font-size: 12px;
    padding: 0px 14px;
    border-radius: 30px !important;
  }
}

.rockbank-dashboard-title {
  font-size: 24px;
  font-weight: 600;
}
@media (max-width: 575px) {
  .rockbank-dashboard-title {
    font-size: 16px;
  }
}

.single-progress .progress {
  height: 10px;
  background: rgba(255, 255, 255, 0.2);
  border: 1px rgba(255, 255, 255, 0.08);
  border-radius: 172px;
}
.single-progress .progress .progress-bar {
  background: linear-gradient(135deg, rgb(253, 216, 25) 0%, rgb(248, 23, 23) 100%);
  border-radius: 4.5px;
  opacity: 0.6;
  box-shadow: inset 4px -4px 10px 0px rgba(255, 255, 255, 0.1);
}

.timeline-grid {
  display: grid;
  grid-template-columns: auto 172px auto;
  align-items: center;
  gap: 8px;
  width: max-content;
}

.dashboard-header {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 14px 30px;
  border-bottom: 1px solid rgba(0, 0, 0, 0.07);
  min-height: 80px;
}
@media (max-width: 575px) {
  .dashboard-header {
    padding: 14px 15px;
    min-height: 70px;
  }
}

.header-right-content {
  display: flex;
  align-items: center;
}

.header-right-content .btn-wrap .site-btn {
  padding: 0 20px;
  border-radius: 30px;
  font-size: 12px;
}
@media (max-width: 480px) {
  .header-right-content .btn-wrap .site-btn {
    padding: 0 10px;
  }
}
.header-right-content .user-action > ul {
  display: flex;
  align-items: center;
  gap: 20px;
}
@media (max-width: 480px) {
  .header-right-content .user-action > ul {
    gap: 16px;
  }
}
.header-right-content .user-action > ul li {
  list-style: none;
}
.header-right-content .user-action > ul li .language-box .language-switcher .language-swit-btn {
  border: 0;
  background: transparent;
  font-size: 14px;
  font-weight: 500;
  padding-inline-start: 0;
  padding-inline-end: 18px;
  display: flex;
  align-items: center;
  height: auto;
}
.header-right-content .user-action > ul li .language-box .language-switcher .language-swit-btn::after {
  width: 8px;
  height: 8px;
  inset-inline-end: 0;
}
.header-right-content .user-action > ul li .language-box .language-switcher .language-swit-btn .option {
  min-height: 35px;
  line-height: 35px;
}
.header-right-content .user-action > ul li .notification-box {
  position: relative;
}
.header-right-content .user-action > ul li .notification-box .icon {
  position: relative;
  font-size: 20px;
  top: 2px;
}
.header-right-content .user-action > ul li .notification-box .number-badge {
  height: 14px;
  width: 14px;
  border-radius: 50%;
  background: #F34141;
  position: absolute;
  color: var(--white);
  top: 2px;
  inset-inline-end: -2px;
  font-size: 10px;
  font-weight: 700;
  display: flex;
  justify-content: center;
  align-items: center;
}
.header-right-content .user-head-drop-btn {
  margin-inline-start: 25px;
  width: 40px;
  height: 40px;
}
@media (max-width: 575px) {
  .header-right-content .user-head-drop-btn {
    margin-inline-start: 10px;
  }
}
.header-right-content .user-head-drop-btn::after {
  display: none;
}
.header-right-content .user-head-drop-btn img {
  border-radius: 50%;
  border: 2px solid var(--primary);
}
.header-right-content .language-box .header-lang-item ul {
  top: 220%;
}
.header-right-content .language-box .header-lang-item > span {
  color: var(--text-primary);
}

.user-profile-info {
  display: flex;
  align-items: center;
  gap: 10px;
}
.user-profile-info .thumb {
  width: 40px;
  height: 40px;
}
.user-profile-info .thumb img {
  border-radius: 50%;
  border: 2px solid var(--primary);
}
.user-profile-info .content .title {
  font-size: 16px;
  margin-bottom: 2px;
}
.user-profile-info .content .user-status {
  color: var(--primary);
  font-size: 14px;
}

.user-profile-drop .dropdown-menu {
  width: 215px;
  padding: 20px 20px;
  background: var(--white);
  border: 1px solid rgba(255, 255, 240, 0.06);
  border-radius: 5px;
  margin-top: 20px !important;
  -webkit-box-shadow: 0px 25px 70px rgba(8, 10, 55, 0.1);
  box-shadow: 0px 25px 70px rgba(8, 10, 55, 0.1);
}
.user-profile-drop .info-list {
  border-top: 1px solid rgba(0, 0, 0, 0.1);
  margin-top: 15px;
  padding-top: 15px;
}
.user-profile-drop .info-list ul li {
  list-style: none;
}
.user-profile-drop .info-list ul li:not(:last-child) {
  margin-bottom: 15px;
}
.user-profile-drop .info-list ul li .content {
  position: relative;
  display: flex;
  align-items: center;
  gap: 8px;
}
.user-profile-drop .info-list ul li .content .icon i {
  font-size: 18px;
  position: relative;
  top: 2px;
}
.user-profile-drop .info-list ul li .content .info a {
  padding: 0px;
  font-size: 14px;
}
.user-profile-drop .info-list ul li .content .info a:hover {
  color: var(--primary);
}
.user-profile-drop .info-list ul li .content .verification-status {
  color: var(--primary);
  line-height: 1;
  font-size: 10px;
  position: absolute;
  inset-inline-start: 28px;
  bottom: -15px;
}
.user-profile-drop .user-logout {
  border-top: 1px solid rgba(3, 3, 6, 0.08);
  margin-top: 30px;
  padding-top: 10px;
}
.user-profile-drop .user-logout .dropdown-item {
  background-color: transparent;
  padding: 0px;
  font-size: 14px;
  display: flex;
  align-items: start;
  gap: 8px;
  font-weight: 500;
  color: #F34141;
}

.toggle-sidebar {
  width: 40px;
  height: 40px;
  display: inline-flex;
  align-items: center;
  justify-content: center;
  background: --white;
  box-shadow: 0px 2px 12px rgba(86, 58, 239, 0.08);
  border-radius: 50%;
}

.bar-icon {
  width: 16px;
  height: 14px;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
  overflow: hidden;
}
.bar-icon span {
  width: 100%;
  height: 2px;
  background: #000000;
  display: inline-block;
}
.bar-icon span:nth-child(2) {
  transition: 0.3s;
  margin-inline-start: -6px;
}
.bar-icon:hover span:nth-child(2) {
  margin-inline-start: 0;
}

.rockbank-page-header {
  max-width: 100vw;
  position: fixed;
  top: 0;
  background-color: var(--white);
  z-index: 9;
  -webkit-transition: 0.5s;
  transition: 0.5s;
  margin-inline-start: 380px;
  width: calc(100% - 380px);
}
@media (max-width: 575px) {
  .rockbank-page-header {
    margin-inline-start: 0;
    width: 100%;
  }
}
.rockbank-page-header.dashboard-sticky {
  position: fixed;
  animation: sticky 0.3s;
  -webkit-animation: sticky 0.3s;
  top: 0;
  width: -webkit-fill-available;
  background: #131314;
}

.page-wrapper .rockbank-page-body-wrapper {
  background-color: #f4f6fd;
}

.rockbank-dashboard-header {
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 18px 30px;
  min-height: 69px;
  border-bottom: 1px solid rgba(255, 255, 255, 0.1);
  background-color: #f4f6fd;
}
@media (max-width: 575px) {
  .rockbank-dashboard-header {
    padding: 15px 15px;
    background: rgba(25, 26, 32, 0.2);
    backdrop-filter: blur(16px);
    min-height: 65px;
  }
}
.rockbank-dashboard-header .header-left-content .content-inner {
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  align-items: center;
  gap: 15px;
}
@media (max-width: 480px) {
  .rockbank-dashboard-header .header-left-content .content-inner {
    gap: 12px;
  }
}
.rockbank-dashboard-header .header-left-content .content-inner .current-status .title {
  font-size: 20px;
  color: var(--white);
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px) {
  .rockbank-dashboard-header .header-left-content .content-inner .current-status .title {
    font-size: 18px;
  }
}
@media (max-width: 480px) {
  .rockbank-dashboard-header .header-left-content .content-inner .current-status .title {
    font-size: 14px;
  }
}
.rockbank-dashboard-header .header-right-content {
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  align-items: center;
}
.rockbank-dashboard-header .header-right-content .btn-wrap {
  margin-inline-end: 25px;
}
@media (max-width: 575px) {
  .rockbank-dashboard-header .header-right-content .btn-wrap {
    margin-inline-end: 10px;
  }
}
.rockbank-dashboard-header .header-right-content .btn-wrap .site-btn {
  padding: 0 20px;
  -webkit-border-radius: 30px;
  -moz-border-radius: 30px;
  -o-border-radius: 30px;
  -ms-border-radius: 30px;
  border-radius: 30px;
  font-size: 12px;
}
@media (max-width: 480px) {
  .rockbank-dashboard-header .header-right-content .btn-wrap .site-btn {
    padding: 0 10px;
  }
}
.rockbank-dashboard-header .header-right-content .btn-wrap .site-btn i {
  font-size: 14px;
}
.rockbank-dashboard-header .header-right-content .user-action > ul {
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  align-items: center;
  gap: 15px;
}
@media (max-width: 480px) {
  .rockbank-dashboard-header .header-right-content .user-action > ul {
    gap: 10px;
  }
}
.rockbank-dashboard-header .header-right-content .user-action > ul li {
  list-style: none;
}
.rockbank-dashboard-header .header-right-content .user-action > ul li .notification-box {
  position: relative;
}
.rockbank-dashboard-header .header-right-content .user-action > ul li .notification-box .icon {
  position: relative;
  font-size: 20px;
  top: 2px;
}
.rockbank-dashboard-header .header-right-content .user-head-drop-btn {
  margin-inline-start: 12px;
  width: 32px;
  height: 32px;
  display: block;
}
@media (max-width: 575px) {
  .rockbank-dashboard-header .header-right-content .user-head-drop-btn {
    margin-inline-start: 10px;
  }
}
@media (max-width: 480px) {
  .rockbank-dashboard-header .header-right-content .user-head-drop-btn {
    margin-inline-start: 8px;
    width: 28px;
    height: 28px;
  }
}
.rockbank-dashboard-header .header-right-content .user-head-drop-btn::after {
  display: none;
}
.rockbank-dashboard-header .header-right-content .user-head-drop-btn img {
  -webkit-border-radius: 50%;
  -moz-border-radius: 50%;
  -o-border-radius: 50%;
  -ms-border-radius: 50%;
  border-radius: 50%;
}
.rockbank-dashboard-header .header-right-content .language-box .header-lang-item ul {
  top: 120%;
  padding: 7px 12px 7px 12px;
  width: 105px;
  box-sizing: border-box;
  background: #242424;
  mix-blend-mode: normal;
  border: 1px solid rgba(255, 255, 255, 0.08);
  backdrop-filter: blur(50px);
  -webkit-border-radius: 10px;
  -moz-border-radius: 10px;
  -o-border-radius: 10px;
  -ms-border-radius: 10px;
  border-radius: 10px;
}
.rockbank-dashboard-header .header-right-content .language-box .header-lang-item ul li:not(:last-child) {
  margin-bottom: 2px;
}
.rockbank-dashboard-header .header-right-content .language-box .header-lang-item ul li a {
  font-size: 14px;
  font-weight: 500;
  color: rgba(255, 255, 255, 0.5);
}
.rockbank-dashboard-header .header-right-content .language-box .header-lang-item ul li a.active {
  color: var(--white);
}
.rockbank-dashboard-header .header-right-content .language-box .header-lang-item ul li a:hover {
  color: var(--white);
}
.rockbank-dashboard-header .header-right-content .language-box .header-lang-item > span {
  color: var(--text-primary);
  background: rgba(255, 255, 255, 0.08);
  border: 1px solid rgba(255, 255, 255, 0.08);
  -webkit-border-radius: 10px;
  -moz-border-radius: 10px;
  -o-border-radius: 10px;
  -ms-border-radius: 10px;
  border-radius: 10px;
  padding: 5px 10px 5px 10px;
  font-size: 14px;
  font-weight: 500;
  color: var(--white);
}
@media (max-width: 480px) {
  .rockbank-dashboard-header .header-right-content .language-box .header-lang-item > span {
    padding: 3px 4px 3px 8px;
  }
}
.rockbank-dashboard-header .header-right-content .light-icon,
.rockbank-dashboard-header .header-right-content .dark-icon {
  cursor: pointer;
}

.notifications-box .notifications-drop-btn::after {
  display: none;
}
.notifications-box .dropdown-menu {
  background: #101016;
  backdrop-filter: blur(50px);
  -webkit-border-radius: 20px;
  -moz-border-radius: 20px;
  -o-border-radius: 20px;
  -ms-border-radius: 20px;
  border-radius: 20px;
  width: 442px;
  top: 150% !important;
  padding: 24px 24px 24px;
  border: 0;
  inset-inline-end: 0;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .notifications-box .dropdown-menu {
    transform: translateX(35%);
  }
}
@media (max-width: 480px) {
  .notifications-box .dropdown-menu {
    transform: translateX(45%);
  }
}
@media (max-width: 480px) {
  .notifications-box .dropdown-menu {
    width: 350px;
    padding: 15px 15px;
  }
}
@media (max-width: 360px) {
  .notifications-box .dropdown-menu {
    width: 300px;
    padding: 15px 15px;
    inset-inline-end: -15px;
  }
}
.notifications-box .dropdown-menu:before {
  position: absolute;
  content: "";
  inset: 0;
  -webkit-border-radius: 20px;
  -moz-border-radius: 20px;
  -o-border-radius: 20px;
  -ms-border-radius: 20px;
  border-radius: 20px;
  padding: 2px;
  background: linear-gradient(139.9deg, rgba(255, 255, 255, 0) 0%, rgba(255, 255, 255, 0.4) 100%);
  -webkit-mask: linear-gradient(var(--white) 0 0) content-box, linear-gradient(var(--white) 0 0);
  -webkit-mask-composite: xor;
  mask-composite: exclude;
  z-index: -1;
}
.notifications-box .notifications-top-content {
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  align-items: center;
  justify-content: space-between;
  margin-bottom: 27px;
}
@media (max-width: 480px) {
  .notifications-box .notifications-top-content {
    margin-bottom: 17px;
  }
}
.notifications-box .notifications-top-content .title {
  color: var(--white);
  font-size: 16px;
  font-weight: 800;
}
@media (max-width: 480px) {
  .notifications-box .notifications-top-content .title {
    font-size: 14px;
  }
}
.notifications-box .notifications-top-content .link {
  color: var(--white);
  font-size: 14px;
  font-weight: 500;
}
@media (max-width: 480px) {
  .notifications-box .notifications-top-content .link {
    font-size: 12px;
  }
}
.notifications-box .notifications-top-content .link:hover {
  color: var(--primary);
}
.notifications-box .notifications-info-wrapper {
  height: 280px;
  overflow-y: scroll;
  scrollbar-width: thin;
  padding-inline-end: 5px;
}
.notifications-box .notifications-info-list ul li .list-item {
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  align-items: start;
  gap: 10px;
  border: 1px solid rgba(255, 255, 255, 0.1);
  -webkit-border-radius: 12px;
  -moz-border-radius: 12px;
  -o-border-radius: 12px;
  -ms-border-radius: 12px;
  border-radius: 12px;
  padding: 10px 10px;
}
.notifications-box .notifications-info-list ul li .list-item .content .title {
  font-size: 14px;
  font-weight: 700;
  color: var(--white);
}
@media (max-width: 480px) {
  .notifications-box .notifications-info-list ul li .list-item .content .title {
    font-size: 12px;
  }
}
.notifications-box .notifications-info-list ul li .list-item .content .info {
  font-size: 11px;
  color: var(--white);
}
.notifications-box .notifications-info-list ul li .list-item:hover {
  background: rgba(255, 255, 255, 0.1);
}
.notifications-box .notifications-info-list ul li:not(:last-child) {
  margin-bottom: 6px;
}
.notifications-box .notifications-bottom-content {
  margin-top: 24px;
}
@media (max-width: 480px) {
  .notifications-box .notifications-bottom-content {
    margin-top: 14px;
  }
}
.notifications-box .notifications-bottom-content .notifications-btn {
  background: rgba(255, 255, 255, 0.08);
  border: 1px solid rgba(255, 255, 255, 0.08);
  -webkit-border-radius: 12px;
  -moz-border-radius: 12px;
  -o-border-radius: 12px;
  -ms-border-radius: 12px;
  border-radius: 12px;
  width: 100%;
  display: inline-flex;
  align-items: center;
  justify-content: center;
  height: 38px;
  color: var(--white);
  font-size: 14px;
  font-weight: 800;
}

.user-profile-drop .dropdown-menu {
  background: var(--white);
  mix-blend-mode: normal;
  border: 1px solid rgba(255, 255, 255, 0.08);
  -webkit-border-radius: 12px;
  -moz-border-radius: 12px;
  -o-border-radius: 12px;
  -ms-border-radius: 12px;
  border-radius: 12px;
  padding: 12px 12px;
  width: 224px;
}
.user-profile-drop .dropdown-menu .user-logout .user-logout-btn {
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  align-items: center;
  gap: 8px;
  background: rgba(248, 23, 23, 0.08);
  -webkit-border-radius: 10px;
  -moz-border-radius: 10px;
  -o-border-radius: 10px;
  -ms-border-radius: 10px;
  border-radius: 10px;
  padding: 8px 8px;
  color: var(--white);
  font-size: 14px;
  font-weight: 500;
  color: #F81717;
}
.user-profile-drop .dropdown-info-list ul li a .content {
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  align-items: center;
  gap: 8px;
  -webkit-border-radius: 10px;
  -moz-border-radius: 10px;
  -o-border-radius: 10px;
  -ms-border-radius: 10px;
  border-radius: 10px;
  padding: 8px 8px;
  font-size: 14px;
  font-weight: 500;
  color: var(--white);
}
@media (max-width: 480px) {
  .user-profile-drop .dropdown-info-list ul li a .content {
    padding: 6px 8px;
    font-size: 12px;
  }
}
.user-profile-drop .dropdown-info-list ul li a:hover .content {
  background-color: rgba(255, 255, 255, 0.08);
  color: var(--white);
}

.rockbank-sidebar-wrapper {
  border-inset-inline-end: 1px solid rgba(255, 255, 255, 0.1);
  position: fixed;
  top: 0;
  z-index: 9;
  width: 380px;
  text-align: left;
  -webkit-transition: 0.3s;
  transition: 0.3s;
  height: 100vh;
  background: var(--white);
  box-shadow: 4px 0px 55px rgba(86, 58, 239, 0.04);
}
@media (max-width: 480px) {
  .rockbank-sidebar-wrapper {
    width: 290px;
  }
}

.rockbank-page-header.close_icon {
  margin-inline-start: 0;
  width: 100%;
}

.rockbank-sidebar-wrapper.close_icon {
  -webkit-transition: all 0.3s ease;
  transition: all 0.3s ease;
  margin-inline-start: -380px;
}

.page-wrapper.compact-wrapper .rockbank-page-body-wrapper div.rockbank-sidebar-wrapper.close_icon ~ .rockbank-page-body {
  margin-inline-start: 0;
  -webkit-transition: 0.5s;
  transition: 0.5s;
}

@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px), only screen and (min-width: 1200px) and (max-width: 1399px) {
  .rockbank-page-body-wrapper .rockbank-page-body {
    margin-inline-start: 0 !important;
  }
}

.rockbank-sidebar-wrapper .back-btn {
  display: none;
}

@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .page-wrapper.compact-wrapper .rockbank-page-body-wrapper .back-btn {
    display: inline-block;
    font-size: 16px;
    cursor: pointer;
    width: 40px;
    height: 40px;
    display: -webkit-inline-box;
    display: -moz-inline-box;
    display: -ms-inline-flexbox;
    display: -webkit-inline-flex;
    display: inline-flexbox;
    display: inline-flex;
    align-items: center;
    justify-content: center;
    background: var(--white);
    color: var(--text-primary);
    background: #f4f6fd;
    border: 1px solid rgba(255, 255, 255, 0.08);
    -webkit-border-radius: 50%;
    -moz-border-radius: 50%;
    -o-border-radius: 50%;
    -ms-border-radius: 50%;
    border-radius: 50%;
  }
}
.bg-overlay.active {
  height: 100vh;
  width: 100vw;
  background-color: rgba(0, 0, 0, 0.5);
  position: fixed;
  z-index: 8;
  top: 0;
}

@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px), only screen and (min-width: 1200px) and (max-width: 1399px) {
  .page-wrapper.compact-wrapper .rockbank-page-header {
    margin-inline-start: 0;
    width: 100%;
  }
}

.site-logo {
  min-height: 80px;
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  align-items: center;
  justify-content: space-between;
  border-bottom: 1px solid rgba(0, 0, 0, 0.07);
  padding-inline-start: 25px;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .site-logo {
    padding-inline-start: 20px;
    padding-inline-end: 12px;
  }
}
.site-logo .logo {
  max-width: 145px;
}
.site-logo .logo img {
  height: 30px;
  width: 100%;
  object-fit: cover;
}

.app-sidebar {
  overflow-y: scroll;
  transition: 0.1s;
  height: calc(100% - 70px);
  -ms-overflow-style: none;
  /* IE and Edge */
  scrollbar-width: none;
  /* Firefox */
}
.app-sidebar.nav-unfolded {
  inset-inline-start: 0;
  z-index: 2;
}
.app-sidebar::-webkit-scrollbar {
  width: 0px;
}
.app-sidebar::-webkit-scrollbar-thumb {
  -webkit-border-radius: 10px;
  -moz-border-radius: 10px;
  -o-border-radius: 10px;
  -ms-border-radius: 10px;
  border-radius: 10px;
  background: rgba(0, 48, 73, 0.3);
}
.app-sidebar::-webkit-scrollbar-track {
  -webkit-border-radius: 10px;
  -moz-border-radius: 10px;
  -o-border-radius: 10px;
  -ms-border-radius: 10px;
  border-radius: 10px;
  background: rgba(0, 18, 25, 0.3);
}
.app-sidebar .rockbank-sidebar-nav {
  padding: 0 12px;
}
.app-sidebar .rockbank-sidebar-nav .user-nav ul li {
  margin-bottom: 5px;
  display: block;
}
.app-sidebar .rockbank-sidebar-nav .user-nav ul li:last-child {
  margin-bottom: 0;
}
.app-sidebar .rockbank-sidebar-nav .user-nav ul li.separator {
  margin-top: 25px;
  border-top: 1px solid rgba(255, 255, 255, 0.1);
  display: inline-flex;
  padding-bottom: 20px;
  width: 100%;
}
.app-sidebar .rockbank-sidebar-nav .user-nav ul li a {
  padding: 0px 25px;
  -webkit-border-radius: 12px;
  -moz-border-radius: 12px;
  -o-border-radius: 12px;
  -ms-border-radius: 12px;
  border-radius: 12px;
  font-size: 16px;
  font-weight: 600;
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  align-items: center;
  height: 56px;
  position: relative;
  gap: 8px;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px) {
  .app-sidebar .rockbank-sidebar-nav .user-nav ul li a {
    height: 48px;
    padding: 0px 20px;
    font-size: 14px;
  }
}
.app-sidebar .rockbank-sidebar-nav .user-nav ul li a i {
  font-size: 20px;
  margin-inline-end: 9px;
  position: relative;
}
.app-sidebar .rockbank-sidebar-nav .user-nav ul li a > span {
  color: --text-primary;
}
.app-sidebar .rockbank-sidebar-nav .user-nav ul li a:hover {
  background: rgba(35, 95, 62, 0.15);
}
.app-sidebar .rockbank-sidebar-nav .user-nav ul li.active {
  position: relative;
}
.app-sidebar .rockbank-sidebar-nav .user-nav ul li.active a {
  position: relative;
  z-index: 5;
  overflow: hidden;
  background: var(--primary);
  -webkit-border-radius: 12px;
  -moz-border-radius: 12px;
  -o-border-radius: 12px;
  -ms-border-radius: 12px;
  border-radius: 12px;
  color: var(--white);
}
.app-sidebar .rockbank-sidebar-nav .user-nav ul li.active a span {
  color: var(--white);
  fill: var(--white);
}
.app-sidebar .rockbank-sidebar-nav .user-nav ul li.logout a {
  color: var(--danger);
  background: rgba(var(--danger), 0.1);
}
.app-sidebar .rockbank-sidebar-nav .user-nav ul li.logout a:hover {
  background: var(--danger);
  color: var(--white);
}
.app-sidebar .rockbank-sidebar-nav .user-nav ul li.logout a:hover span {
  color: var(--white);
}

.sidebar-inner {
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
  height: 100%;
  gap: 20px 0;
}

.rockbank-sidebar-logout {
  padding: 25px 12px 25px;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px) {
  .rockbank-sidebar-logout {
    padding: 20px 12px 20px;
  }
}
.rockbank-sidebar-logout .submit {
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  align-items: center;
  gap: 8px;
  color: var(--danger);
  font-weight: 600;
  font-size: 16px;
  width: 100%;
  height: 56px;
  padding: 0px 20px;
  border-radius: 8px;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px) {
  .rockbank-sidebar-logout .submit {
    height: 48px;
    font-size: 14px;
  }
}
.rockbank-sidebar-logout .submit:hover {
  background: rgba(243, 65, 65, 0.2);
}

.rockbank-page-body {
  margin-top: 80px;
  margin-inline-start: 380px;
  padding: 30px 20px 30px 20px;
  position: relative;
  -webkit-transition: 0.5s;
  transition: 0.5s;
  min-height: 100vh;
}
@media only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px), only screen and (min-width: 1200px) and (max-width: 1399px) {
  .rockbank-page-body {
    padding: 30px 15px 30px 15px;
  }
}
@media (max-width: 575px) {
  .rockbank-page-body {
    padding: 15px 0px 15px 0px;
    margin-top: 70px;
  }
}

/*----------------------------------------*/
/* Body content
/*----------------------------------------*/
.rockbank-dashboard-level-area {
  margin-bottom: 12px;
}
@media (max-width: 575px) {
  .rockbank-dashboard-level-area {
    margin-bottom: 16px;
  }
}

.rockbank-dashboard-level-wrapper {
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  align-items: center;
  justify-content: space-between;
  gap: 20px 20px;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px) {
  .rockbank-dashboard-level-wrapper {
    flex-direction: column;
  }
}

.rockbank-dashboard-level-contents {
  background-repeat: no-repeat;
  background-size: cover;
  padding: 12px 20px;
  min-width: 454px;
  border-radius: 120px;
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  align-items: center;
  gap: 16px;
  flex: 0 0 auto;
  border: 1px solid rgba(255, 255, 255, 0.1);
}
@media only screen and (min-width: 1600px) and (max-width: 1800px) {
  .rockbank-dashboard-level-contents {
    min-width: 454px;
  }
}
@media only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .rockbank-dashboard-level-contents {
    min-width: inherit;
  }
}
@media only screen and (min-width: 576px) and (max-width: 767px) {
  .rockbank-dashboard-level-contents {
    min-width: 100%;
  }
}
@media (max-width: 575px) {
  .rockbank-dashboard-level-contents {
    padding: 0;
    border: 0;
    flex-direction: row-reverse;
    justify-content: space-between;
    min-width: 100%;
  }
}
.rockbank-dashboard-level-contents .thumb {
  flex: 0 0 auto;
}
@media (max-width: 575px) {
  .rockbank-dashboard-level-contents .thumb {
    height: 64px;
    width: 64px;
    display: inline-flex;
    align-items: center;
    justify-content: center;
    background-repeat: no-repeat;
    background-size: cover;
    -webkit-border-radius: 50%;
    -moz-border-radius: 50%;
    -o-border-radius: 50%;
    -ms-border-radius: 50%;
    border-radius: 50%;
    border: 0.755507px solid rgba(255, 255, 255, 0.1);
  }
}
.rockbank-dashboard-level-contents .thumb img {
  filter: drop-shadow(0px 4px 24px #FFE793);
}
@media (max-width: 575px) {
  .rockbank-dashboard-level-contents .thumb img {
    width: 30px;
  }
}
.rockbank-dashboard-level-contents .content .lavel {
  font-size: 20px;
  font-weight: 500;
  color: var(--white);
  display: block;
  margin-bottom: 5px;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .rockbank-dashboard-level-contents .content .lavel {
    font-size: 18px;
  }
}
.rockbank-dashboard-level-contents .content .lavel-title {
  font-size: 20px;
  color: var(--primary);
  font-weight: 800;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .rockbank-dashboard-level-contents .content .lavel-title {
    font-size: 18px;
  }
}

.rockbank-dashboard-referral {
  padding-bottom: 10px;
  border-bottom: 1px solid rgba(255, 255, 255, 0.1);
}
.rockbank-dashboard-referral .contents .link-title {
  font-size: 18px;
  color: var(--white);
  margin-bottom: 15px;
}
@media only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .rockbank-dashboard-referral .contents .link-title {
    margin-bottom: 10px;
  }
}
@media (max-width: 575px) {
  .rockbank-dashboard-referral .contents .link-title {
    margin-bottom: 15px;
    font-size: 14px;
    text-transform: uppercase;
  }
}
.rockbank-dashboard-referral .contents .referral-link {
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  align-items: center;
  gap: 0 87px;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .rockbank-dashboard-referral .contents .referral-link {
    gap: 20px;
  }
}
.rockbank-dashboard-referral .contents .referral-link .referral-url-copy {
  margin-bottom: 0;
  font-style: italic;
  font-size: 14px;
  font-weight: 400;
}
.rockbank-dashboard-referral .contents .referral-link .copy-message {
  position: absolute;
  font-size: 12px;
  top: -30px;
  inset-inline-end: 0;
  background-color: #4CAF50;
  color: var(--white);
  padding: 4px 8px 3px;
  border-radius: 5px;
  opacity: 0;
  transition: opacity 0.3s ease;
}

.rockbank-dashboard-grid {
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  align-items: start;
  gap: 15px 12px;
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px) {
  .rockbank-dashboard-grid {
    flex-direction: column;
  }
}

.rockbank-account-card-wrapper {
  border-radius: 20px;
  padding: 24px 24px 28px;
  z-index: 2;
}
.rockbank-account-card-wrapper > .title {
  font-size: 18px;
  color: var(--white);
  margin-bottom: 15px;
}
.rockbank-account-card-wrapper .rockbank-account-btn {
  margin-top: 16px;
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  align-items: center;
  gap: 10px;
}
.rockbank-account-card-wrapper .rockbank-account-btn .rockbank-btn {
  height: 42px;
  border-radius: 10px;
  font-size: 14px;
  font-weight: 600;
  width: 100%;
  padding: 0 15px;
}
@media (max-width: 480px) {
  .rockbank-account-card-wrapper .rockbank-account-btn .rockbank-btn {
    padding: 0 8px;
  }
}

.rockbank-account-card-main .rockbank-account-card {
  padding: 14px 16px;
  position: relative;
  background: rgba(255, 255, 255, 0.15);
  border: 1px solid rgba(255, 255, 255, 0.2);
  backdrop-filter: blur(10px);
  border-radius: 8px;
}
@media (max-width: 575px) {
  .rockbank-account-card-main .rockbank-account-card {
    margin-top: auto;
    margin-bottom: 40px;
  }
}
.rockbank-account-card-main .rockbank-account-card .content-inner {
  position: relative;
  z-index: 5;
  display: flex;
  align-items: center;
  justify-content: space-between;
  position: relative;
}
.rockbank-account-card-main .rockbank-account-card .content-inner::before {
  position: absolute;
  content: "";
  height: 100%;
  width: 1px;
  background-color: rgba(255, 255, 255, 0.5);
  inset-inline-start: 50%;
  transform: translateX(-50%);
}
.rockbank-account-card-main .rockbank-account-card .content-inner .card-content .balance {
  font-size: 18px;
  font-weight: 600;
  color: var(--white);
}
@media (max-width: 480px) {
  .rockbank-account-card-main .rockbank-account-card .content-inner .card-content .balance {
    font-size: 16px;
  }
}
.rockbank-account-card-main .rockbank-account-card .content-inner .card-content .title {
  display: block;
  font-size: 12px;
  margin-bottom: 6px;
  color: var(--white);
}
@media (max-width: 480px) {
  .rockbank-account-card-main .rockbank-account-card .content-inner .card-content .title {
    font-size: 10px;
  }
}

.rockbank-single-card-grid {
  width: 100%;
  display: -ms-grid;
  display: -moz-grid;
  display: grid;
  grid-template-columns: repeat(4, 1fr);
  gap: 30px;
}
@media only screen and (min-width: 1600px) and (max-width: 1800px), only screen and (min-width: 1400px) and (max-width: 1599px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .rockbank-single-card-grid {
    grid-template-columns: repeat(3, 1fr);
  }
}
@media only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 576px) and (max-width: 767px) {
  .rockbank-single-card-grid {
    grid-template-columns: repeat(2, 1fr);
  }
}
@media (max-width: 575px), only screen and (min-width: 576px) and (max-width: 767px) {
  .rockbank-single-card-grid {
    grid-template-columns: 1fr;
  }
}

.rockbank-single-card {
  padding: 30px 30px 30px;
  background: var(--white);
  border-radius: 10px;
  position: relative;
}
.rockbank-single-card::before {
  position: absolute;
  content: "";
  bottom: 0;
  inset-inline-end: 0;
  width: 112px;
  height: 124px;
  background-color: #19C1DD;
  clip-path: polygon(0% 99.589%, 35.253% 99.517%, 72.768% 100%, 93.856% 99.52%, 93.856% 99.52%, 94.851% 99.426%, 95.792% 99.198%, 96.667% 98.846%, 97.465% 98.383%, 98.174% 97.818%, 98.781% 97.164%, 99.274% 96.432%, 99.641% 95.632%, 99.87% 94.777%, 99.949% 93.877%, 99.949% 75.893%, 99.975% 68.074%, 100% 60.255%, 100% 52.56%, 100% 44.866%, 100% 29.477%, 100% 0%, 100% 0%, 99.923% 0.742%, 99.614% 2.853%, 98.955% 6.156%, 97.829% 10.477%, 96.117% 15.641%, 93.701% 21.473%, 90.464% 27.798%, 86.288% 34.441%, 81.056% 41.227%, 74.649% 47.981%, 74.649% 47.981%, 66.43% 54.76%, 57.332% 60.724%, 47.749% 66.045%, 38.071% 70.892%, 28.692% 75.437%, 20.004% 79.849%, 12.398% 84.3%, 6.267% 88.96%, 2.004% 94%, 0% 99.589%);
}
@media (max-width: 575px) {
  .rockbank-single-card::before {
    width: 72px;
    height: 64px;
  }
}
@media only screen and (min-width: 1400px) and (max-width: 1599px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .rockbank-single-card {
    padding: 15px 15px;
  }
}
@media (max-width: 575px) {
  .rockbank-single-card {
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-box;
    display: -webkit-flex;
    display: flex;
    gap: 12px;
    padding: 14px 14px 12px;
  }
}
.rockbank-single-card .icon {
  margin-bottom: 25px;
}
.rockbank-single-card .icon span {
  width: 67px;
  height: 67px;
  display: inline-flex;
  align-items: center;
  justify-content: center;
  background: #19C2DD;
  font-size: 20px;
  color: #fff;
  border-radius: 81% 19% 23% 77%/58% 52% 48% 42%;
  position: relative;
}
.rockbank-single-card .icon span::before {
  position: absolute;
  content: "";
  width: 53px;
  height: 53.6px;
  top: 50%;
  inset-inline-start: 50%;
  transform: translate(-50%, -50%);
  background: #19C2DD;
  filter: blur(34px);
}
.rockbank-single-card .content .title {
  font-size: 24px;
}
@media only screen and (min-width: 1400px) and (max-width: 1599px), only screen and (min-width: 1200px) and (max-width: 1399px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .rockbank-single-card .content .title {
    font-size: 24px;
  }
}
@media only screen and (min-width: 576px) and (max-width: 767px), only screen and (min-width: 768px) and (max-width: 991px), only screen and (min-width: 992px) and (max-width: 1199px) {
  .rockbank-single-card .content .title {
    font-size: 20px;
  }
}
@media (max-width: 575px) {
  .rockbank-single-card .content .title {
    font-size: 20px;
  }
}
.rockbank-single-card .content .title span {
  margin-inline-end: 5px;
}
.rockbank-single-card .content .description {
  color: var(--black);
  font-size: 14px;
  font-weight: 500;
  margin-bottom: 10px;
}
.rockbank-single-card .summertime-shape {
  width: 74px;
  height: 74px;
  background-color: #19C1DD;
  display: inline-flex;
  clip-path: polygon(25% 0%, 25% 0%, 20.945% 0.327%, 17.098% 1.275%, 13.511% 2.79%, 10.235% 4.824%, 7.322% 7.322%, 4.824% 10.235%, 2.79% 13.511%, 1.275% 17.098%, 0.327% 20.945%, 0% 25%, 0% 25%, 0.327% 29.055%, 1.275% 32.902%, 2.79% 36.489%, 4.824% 39.765%, 7.322% 42.678%, 10.235% 45.177%, 13.511% 47.21%, 17.098% 48.726%, 20.945% 49.673%, 25% 50%, 25% 50%, 20.945% 50.327%, 17.098% 51.274%, 13.511% 52.79%, 10.235% 54.823%, 7.322% 57.322%, 4.824% 60.235%, 2.79% 63.511%, 1.275% 67.098%, 0.327% 70.945%, 0% 75%, 0% 75%, 0.327% 79.055%, 1.275% 82.902%, 2.79% 86.489%, 4.824% 89.765%, 7.322% 92.678%, 10.235% 95.177%, 13.511% 97.21%, 17.098% 98.726%, 20.945% 99.673%, 25% 100%, 25% 100%, 29.055% 99.673%, 32.902% 98.726%, 36.489% 97.21%, 39.765% 95.177%, 42.678% 92.678%, 45.177% 89.765%, 47.21% 86.489%, 48.726% 82.902%, 49.673% 79.055%, 50% 75%, 50% 75%, 50.327% 79.055%, 51.274% 82.902%, 52.79% 86.489%, 54.823% 89.765%, 57.322% 92.678%, 60.235% 95.177%, 63.511% 97.21%, 67.098% 98.726%, 70.945% 99.673%, 75% 100%, 75% 100%, 79.055% 99.673%, 82.902% 98.726%, 86.489% 97.21%, 89.765% 95.177%, 92.678% 92.678%, 95.177% 89.765%, 97.21% 86.489%, 98.726% 82.902%, 99.673% 79.055%, 100% 75%, 100% 75%, 99.673% 70.945%, 98.726% 67.098%, 97.21% 63.511%, 95.177% 60.235%, 92.678% 57.322%, 89.765% 54.823%, 86.489% 52.79%, 82.902% 51.274%, 79.055% 50.327%, 75% 50%, 75% 50%, 79.055% 49.673%, 82.902% 48.726%, 86.489% 47.21%, 89.765% 45.177%, 92.678% 42.678%, 95.177% 39.765%, 97.21% 36.489%, 98.726% 32.902%, 99.673% 29.055%, 100% 25%, 100% 25%, 99.673% 20.945%, 98.726% 17.098%, 97.21% 13.511%, 95.177% 10.235%, 92.678% 7.322%, 89.765% 4.824%, 86.489% 2.79%, 82.902% 1.275%, 79.055% 0.327%, 75% 0%, 75% 0%, 70.945% 0.327%, 67.098% 1.275%, 63.511% 2.79%, 60.235% 4.824%, 57.322% 7.322%, 54.823% 10.235%, 52.79% 13.511%, 51.274% 17.098%, 50.327% 20.945%, 50% 25%, 50% 25%, 49.673% 20.945%, 48.726% 17.098%, 47.21% 13.511%, 45.177% 10.235%, 42.678% 7.322%, 39.765% 4.824%, 36.489% 2.79%, 32.902% 1.275%, 29.055% 0.327%, 25% 0%);
  position: absolute;
  inset-inline-end: 0;
  top: 30px;
  inset-inline-end: 50px;
  opacity: 0.05;
}
@media (max-width: 575px) {
  .rockbank-single-card .summertime-shape {
    width: 40px;
    height: 40px;
    inset-inline-end: 30px;
  }
}
.rockbank-single-card:nth-child(3) .icon span {
  background-color: var(--secondary);
}
.rockbank-single-card:nth-child(3) .icon span::before {
  background-color: var(--secondary);
}
.rockbank-single-card:nth-child(3)::before {
  background-color: var(--secondary);
}
.rockbank-single-card:nth-child(3) .summertime-shape {
  background-color: var(--secondary);
}
.rockbank-single-card:nth-child(4) .icon span {
  background-color: #6B40EA;
}
.rockbank-single-card:nth-child(4) .icon span::before {
  background-color: #6B40EA;
}
.rockbank-single-card:nth-child(4)::before {
  background-color: #6B40EA;
}
.rockbank-single-card:nth-child(5) .icon span {
  background-color: #136EF9;
}
.rockbank-single-card:nth-child(5) .icon span::before {
  background-color: #136EF9;
}
.rockbank-single-card:nth-child(5)::before {
  background-color: #136EF9;
}
.rockbank-single-card:nth-child(5) .summertime-shape {
  background-color: #136EF9;
}
.rockbank-single-card:nth-child(6) .icon span {
  background-color: #FFAF34;
}
.rockbank-single-card:nth-child(6) .icon span::before {
  background-color: #FFAF34;
}
.rockbank-single-card:nth-child(6)::before {
  background-color: #FFAF34;
}
.rockbank-single-card:nth-child(6) .summertime-shape {
  background-color: #FFAF34;
}
.rockbank-single-card:nth-child(7) .icon span {
  background-color: #16C113;
}
.rockbank-single-card:nth-child(7) .icon span::before {
  background-color: #16C113;
}
.rockbank-single-card:nth-child(7)::before {
  background-color: #16C113;
}
.rockbank-single-card:nth-child(7) .summertime-shape {
  background-color: #16C113;
}
.rockbank-single-card:nth-child(8) .icon span {
  background-color: #1AE5FF;
}
.rockbank-single-card:nth-child(8) .icon span::before {
  background-color: #1AE5FF;
}
.rockbank-single-card:nth-child(8)::before {
  background-color: #1AE5FF;
}
.rockbank-single-card:nth-child(8) .summertime-shape {
  background-color: #1AE5FF;
}
.rockbank-single-card:nth-child(9) .icon span {
  background-color: #0D9249;
}
.rockbank-single-card:nth-child(9) .icon span::before {
  background-color: #0D9249;
}
.rockbank-single-card:nth-child(9)::before {
  background-color: #0D9249;
}
.rockbank-single-card:nth-child(9) .summertime-shape {
  background-color: #0D9249;
}
.rockbank-single-card:nth-child(10) .icon span {
  background-color: #DB57F0;
}
.rockbank-single-card:nth-child(10) .icon span::before {
  background-color: #DB57F0;
}
.rockbank-single-card:nth-child(10)::before {
  background-color: #DB57F0;
}
.rockbank-single-card:nth-child(10) .summertime-shape {
  background-color: #DB57F0;
}
.rockbank-single-card:nth-child(11) .icon span {
  background-color: #995CFD;
}
.rockbank-single-card:nth-child(11) .icon span::before {
  background-color: #995CFD;
}
.rockbank-single-card:nth-child(11)::before {
  background-color: #995CFD;
}
.rockbank-single-card:nth-child(11) .summertime-shape {
  background-color: #995CFD;
}
.rockbank-single-card:nth-child(10) .icon span {
  background-color: #FD655C;
}
.rockbank-single-card:nth-child(10) .icon span::before {
  background-color: #FD655C;
}
.rockbank-single-card:nth-child(10)::before {
  background-color: #FD655C;
}
.rockbank-single-card:nth-child(10) .summertime-shape {
  background-color: #FD655C;
}

.rockbank-referral-form .title {
  color: var(--white);
  font-size: 20px;
  margin-bottom: 20px;
}
@media (max-width: 575px) {
  .rockbank-referral-form .title {
    font-size: 18px;
    text-transform: uppercase;
  }
}
@media (max-width: 480px) {
  .rockbank-referral-form .title {
    font-size: 14px;
  }
}

.rockbank-referral-form-grid .rockbank-single-input .input-field {
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-box;
  display: -webkit-flex;
  display: flex;
  align-items: end;
  gap: 16px 20px;
  width: 100%;
}
@media (max-width: 480px) {
  .rockbank-referral-form-grid .rockbank-single-input .input-field {
    flex-wrap: wrap;
  }
}
.rockbank-referral-form-grid .rockbank-single-input .input-field input {
  color: rgba(0, 0, 0, 0.6);
  background: #F9FAFB;
  border: 1px solid rgba(0, 0, 0, 0.07);
  border-radius: 10px;
}
.rockbank-referral-form-grid .rockbank-single-input .input-field input::-webkit-input-placeholder { /* Chrome/Opera/Safari */
  color: rgba(0, 0, 0, 0.6);
}
.rockbank-referral-form-grid .rockbank-single-input .input-field input::-moz-placeholder { /* Firefox 19+ */
  color: rgba(0, 0, 0, 0.6);
}
.rockbank-referral-form-grid .rockbank-single-input .input-field input:-moz-placeholder { /* Firefox 4-18 */
  color: rgba(0, 0, 0, 0.6);
}
.rockbank-referral-form-grid .rockbank-single-input .input-field input:-ms-input-placeholder { /* IE 10+  Edge*/
  color: rgba(0, 0, 0, 0.6);
}
.rockbank-referral-form-grid .rockbank-single-input .input-field input::placeholder { /* MODERN BROWSER */
  color: rgba(0, 0, 0, 0.6);
}
@media (max-width: 575px) {
  .rockbank-referral-form-grid .rockbank-single-input .input-field .site-btn {
    padding: 0 15px;
  }
}
@media (max-width: 480px) {
  .rockbank-referral-form-grid .rockbank-single-input .input-field .site-btn {
    width: 100%;
  }
}
.rockbank-referral-form-grid .rockbank-single-input .description {
  font-size: 12px;
  margin-top: 10px;
}

.copy-url-btn {
  background: #136EF9;
  border-radius: 10px;
  color: var(--white);
  height: 48px;
  padding: 0 30px;
  display: flex;
  align-items: center;
  justify-content: center;
  gap: 5px;
  font-size: 14px;
  font-weight: 600;
}

/*----------------------------------------*/
/* Member badge card css 
/*----------------------------------------*/
.member-badge-card {
  position: relative;
  z-index: 1;
  padding: 0 12px;
}
.member-badge-card .badge-pattern {
  position: absolute;
  top: 0;
  inset-inline-end: -14px;
  height: 100%;
  width: 100%;
  opacity: 0.3;
  z-index: -1;
}
.member-badge-card .badge-pattern img {
  width: 100%;
  height: 100%;
  object-fit: cover;
}

.member-badge-inner {
  display: flex;
  align-items: center;
  gap: 14px 14px;
  background: linear-gradient(115.87deg, #19C2DD 0.99%, #355BFB 78.16%);
  box-shadow: 0px 6px 10px rgba(53, 91, 251, 0.3);
  padding: 20px 20px;
  border-radius: 12px;
}
@media (max-width: 575px) {
  .member-badge-inner {
    padding: 12px 12px;
    gap: 8px 8px;
  }
}

.member-badge-icon {
  width: 63px;
  height: 63px;
  background: var(--white);
  border: 2px solid var(--white);
  box-shadow: 0px 0px 24px rgba(0, 0, 0, 0.15);
  display: inline-flex;
  align-items: center;
  justify-content: center;
  border-radius: 50%;
  flex: 0 0 auto;
}
@media (max-width: 575px) {
  .member-badge-icon {
    padding: 12px 12px;
    width: 52px;
    height: 52px;
  }
}

.member-badge-contents .title {
  font-size: 18px;
  color: var(--white);
  margin-bottom: 5px;
}
@media (max-width: 575px) {
  .member-badge-contents .title {
    font-size: 16px;
  }
}
.member-badge-contents .description {
  font-size: 14px;
  color: rgba(255, 255, 255, 0.8);
}
@media (max-width: 575px) {
  .member-badge-contents .description {
    font-size: 12px;
  }
}

/*# sourceMappingURL=styles.cs.map */
