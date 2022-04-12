/*Importing Basic Style*/
@import url("https://fonts.googleapis.com/css2?family=Jost:wght@600&display=swap");
@import url("https://fonts.googleapis.com/css2?family=Dancing+Script:wght@600&display=swap");
@import url("https://fonts.googleapis.com/css2?family=Jost:wght@600&display=swap");
@import url("https://fonts.googleapis.com/css2?family=Dancing+Script:wght@600&display=swap");
* {
  box-sizing: border-box;
  margin: 0;
  padding: 0;
}

/*font-family: 'Jost', sans-serif;*/
/*font-family: 'Dancing Script', cursive;*/
/*Importing Colors*/
/*Defining Basic Color Schema*/
/*Importing Header*/
/*Importing Basic Style*/
* {
  box-sizing: border-box;
  margin: 0;
  padding: 0;
}

/*font-family: 'Jost', sans-serif;*/
/*font-family: 'Dancing Script', cursive;*/
/*Importing Colors*/
/*Defining Basic Color Schema*/
body {
  font-family: "Jost", sans-serif;
}
body .header {
  align-items: center;
  background-color: rgba(55, 80, 126, 0.9490196078);
  display: flex;
  justify-content: space-between;
  left: 0;
  position: fixed;
  right: 0;
  top: 0;
  z-index: 1000;
}
body .header .logo .logo-link {
  display: block;
}
body .header .logo .logo-link .logo-image {
  vertical-align: bottom;
}
body .header .navigation .nav-links {
  display: flex;
  margin-right: 2rem;
}
body .header .navigation .nav-links .link {
  list-style: none;
  text-align: center;
}
body .header .navigation .nav-links .link .link-anchor {
  color: #ffffff;
  display: inline-block;
  font-size: 1.25rem;
  padding: 1rem 1.5rem;
  text-decoration: none;
}
body .header .navigation .nav-links .active .link-anchor {
  color: #47b2e4;
}
body .header .navigation .nav-links .link:hover .link-anchor {
  color: #47b2e4;
}

@media screen and (max-width: 720px) {
  body .header {
    background-color: #37507e;
    position: static;
  }
  body .header .logo .logo-link .logo-image {
    max-width: 200px;
  }
  body .header .navigation .nav-links {
    margin: 0;
  }
  body .header .navigation .nav-links .link .link-anchor {
    font-size: 1rem;
    padding: 0.5rem 1rem;
  }
}
body .introduction {
  background-color: #37507e;
  display: flex;
  justify-content: center;
  padding: 8rem 2rem;
}
body .introduction .left {
  padding: 2rem 0;
}
body .introduction .left .left-heading {
  animation: text-in 1s 0.2s 1;
  color: #ffffff;
  padding: 2rem 0;
  position: relative;
}
@keyframes text-in {
  0% {
    left: -1000px;
    opacity: 0;
  }
  100% {
    left: 0;
    opacity: 1;
  }
}
body .introduction .left .left-description {
  animation: text-up 1s 0.2s 1;
  color: #ffffff;
  max-width: 80ch;
  position: relative;
}
@keyframes text-up {
  0% {
    bottom: -200px;
    opacity: 0;
  }
  100% {
    bottom: 0;
    opacity: 1;
  }
}
body .introduction .left .search {
  animation: move-in 1s 0.2s 1;
  padding: 3rem 0;
}
body .introduction .left .search input[type=text] {
  border: none;
  border-radius: 1.5rem;
  box-shadow: rgba(149, 157, 165, 0.1) 0px 8px 24px;
  padding: 1rem;
  outline: none;
  width: 50%;
}
body .introduction .left .search input[type=submit] {
  background-color: #47b2e4;
  border: none;
  border-radius: 1.5rem;
  box-shadow: rgba(149, 157, 165, 0.1) 0px 8px 24px;
  color: #ffffff;
  margin-left: -3rem;
  padding: 1rem 2rem;
}
body .introduction .left .search input[type=submit]:hover {
  background-color: #209dd8;
}
@keyframes move-in {
  0% {
    transform: scale(0.1);
  }
  100% {
    transform: scale(1);
  }
}
body .introduction .left .buttons {
  padding: 1rem 0;
  display: flex;
}
body .introduction .left .buttons .btn {
  align-items: center;
  border: 1px solid #ffffff;
  border-radius: 0.5rem;
  color: #ffffff;
  display: flex;
  gap: 0.25rem;
  padding: 0.25rem 1.5rem;
  margin-right: 1.5rem;
  text-decoration: none;
}
body .introduction .left .buttons .btn:hover {
  background-color: #209dd8;
  border-color: #209dd8;
}
body .introduction .left .buttons .btn {
  animation: btn-left-in 1s 0.2s 1;
}
@keyframes btn-left-in {
  0% {
    transform: scale(0.1);
  }
  100% {
    transform: scale(1);
  }
}
body .introduction .right .book-image {
  animation: top-to-bottom 1s 0.2s infinite;
  max-width: 100%;
  position: relative;
  transition: transform 0.7s ease-in-out;
  vertical-align: bottom;
}
@keyframes top-to-bottom {
  0% {
    top: 0;
  }
  50% {
    top: 20px;
  }
  100% {
    top: 0;
  }
}
body .introduction .right .book-image:hover {
  transform: rotate(360deg);
}
body .popular-category {
  background-color: #f3f5fa;
  padding: 2rem 1rem;
  margin: 0 auto;
}
body .popular-category .plr-cat-heading {
  color: #3d3939;
  text-align: center;
  margin: 2rem auto;
}
body .popular-category .plr-cat-heading:hover {
  color: #37507e;
}
body .popular-category .category-wrapper {
  display: grid;
  gap: 2rem;
  /* Explicit grid */
  grid-template-areas: "a  b  c" "d  e  f" "g  h  i" "j  k  l";
  grid-template-rows: repeat(4, 10rem);
  grid-template-columns: repeat(3, minmax(0, 1fr));
  padding: 0 1rem;
  --stagger-initial-delay: 2s;
  --stagger-delay: 200ms;
}
@keyframes catEntrance {
  from {
    opacity: 0;
    transform: scale(0.3);
  }
  to {
    opacity: 1;
    transform: scale(1);
  }
}
body .popular-category .cat {
  animation: catEntrance 700ms ease-out;
  animation-fill-mode: backwards;
  border: 1px solid #3d3939;
  border-radius: 0.2rem;
}
body .popular-category .cat .cat-link {
  align-items: center;
  color: #3d3939;
  display: flex;
  height: 100%;
  justify-content: center;
  text-decoration: none;
  width: 100%;
}
body .popular-category .cat:nth-child(1) {
  grid-area: a;
  animation-delay: calc(1 * var(--stagger-initial-delay));
}
body .popular-category .cat:nth-child(2) {
  grid-area: b;
  animation-delay: calc(var(--stagger-initial-delay) + 1 * var(--stagger-delay));
}
body .popular-category .cat:nth-child(3) {
  grid-area: c;
  animation-delay: calc(var(--stagger-initial-delay) + 2 * var(--stagger-delay));
}
body .popular-category .cat:nth-child(4) {
  grid-area: d;
  animation-delay: calc(var(--stagger-initial-delay) + 3 * var(--stagger-delay));
}
body .popular-category .cat:nth-child(5) {
  grid-area: e;
  animation-delay: calc(var(--stagger-initial-delay) + 4 * var(--stagger-delay));
}
body .popular-category .cat:nth-child(6) {
  grid-area: f;
  animation-delay: calc(var(--stagger-initial-delay) + 5 * var(--stagger-delay));
}
body .popular-category .cat:nth-child(7) {
  grid-area: g;
  animation-delay: calc(var(--stagger-initial-delay) + 6 * var(--stagger-delay));
}
body .popular-category .cat:nth-child(8) {
  grid-area: h;
  animation-delay: calc(var(--stagger-initial-delay) + 7 * var(--stagger-delay));
}
body .popular-category .cat:nth-child(9) {
  grid-area: i;
  animation-delay: calc(var(--stagger-initial-delay) + 8 * var(--stagger-delay));
}
body .popular-category .cat:nth-child(10) {
  grid-area: j;
  animation-delay: calc(var(--stagger-initial-delay) + 9 * var(--stagger-delay));
}
body .popular-category .cat:nth-child(11) {
  grid-area: k;
  animation-delay: calc(var(--stagger-initial-delay) + 10 * var(--stagger-delay));
}
body .popular-category .cat:nth-child(12) {
  grid-area: l;
  animation-delay: calc(var(--stagger-initial-delay) + 11 * var(--stagger-delay));
}
body .popular-category .cat {
  background-color: #ffffff;
}
body .popular-category .cat .cat-link {
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;
  font-family: "Dancing Script", cursive;
  font-size: 1.5rem;
}
body .popular-category .cat:hover {
  border: none;
}
body .popular-category .cat:hover .cat-link {
  color: transparent;
}
body .popular-category .cat-1:hover .cat-link {
  background-image: url(../images/Science-Fiction.png);
}
body .popular-category .cat-2:hover .cat-link {
  background-image: url(../images/Adventure.png);
}
body .popular-category .cat-3:hover .cat-link {
  background-image: url(../images/Fantasy.png);
}
body .popular-category .cat-4:hover .cat-link {
  background-image: url(../images/Time-Travel.png);
}
body .popular-category .cat-5:hover .cat-link {
  background-image: url(../images/Young-Adult.png);
}
body .popular-category .cat-6:hover .cat-link {
  background-image: url(../images/Romance.png);
}
body .popular-category .cat-7:hover .cat-link {
  background-image: url(../images/Thriller.png);
}
body .popular-category .cat-8:hover .cat-link {
  background-image: url(../images/Horror.png);
}
body .popular-category .cat-9:hover .cat-link {
  background-image: url(../images/Mystery.png);
}
body .popular-category .cat-10:hover .cat-link {
  background-image: url(../images/Drama.png);
}
body .popular-category .cat-11:hover .cat-link {
  background-image: url(../images/Biography.png);
}
body .popular-category .cat-12:hover .cat-link {
  background-image: url(../images/Non-Fiction.png);
}
body .featured-books {
  margin: 2rem auto;
  padding: 2rem 0;
}
body .featured-books .featured-book-heading {
  color: #3d3939;
  text-align: center;
  padding: 1rem auto;
}
body .featured-books .featured-book-heading:hover {
  color: #37507e;
}
body .featured-books .book-card-wrapper {
  padding: 2rem;
}

@media screen and (max-width: 720px) {
  body .introduction {
    padding: 1rem 2rem;
  }
  body .introduction .left {
    width: 60%;
  }
  body .introduction .left .left-heading {
    font-size: 1.5rem;
    padding: 0;
  }
  body .introduction .left .left-description {
    padding: 1rem 0;
  }
  body .introduction .left .search {
    display: flex;
    padding: 1rem 0;
  }
  body .introduction .left .search input[type=text] {
    width: 100%;
  }
  body .introduction .left .buttons .btn {
    padding: 0.25rem 0.5rem;
  }
  body .introduction .right {
    width: 40%;
  }
  body .popular-category .category-wrapper {
    grid-template-areas: "a  b" "c  d" "e  f" "g  h" "i  j" "k  l";
    grid-template-rows: repeat(6, 8rem);
    grid-template-columns: repeat(2, minmax(0, 1fr));
  }
}

/*# sourceMappingURL=css.index.cs.map */
