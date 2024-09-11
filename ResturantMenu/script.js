

const lunchBtn = document.getElementById("lunch-btn");
const lunchMeals = document.getElementById("lunch");
const breakfast = document.getElementById("breakfast");
const breakfastBtn = document.getElementById("breakfast-btn");
const dinner = document.getElementById("dinner");
const dinnerBtn = document.getElementById("dinner-btn");

lunchBtn.addEventListener("click", function() {
  breakfast.style.display = "none"
  dinner.style.display = "none"
  lunchMeals.style.display = "block"
});

dinnerBtn.addEventListener("click", function() {
  lunchMeals.style.display = "none"
  breakfast.style.display = "none"
  dinner.style.display = "block"
});
window.onload = function(){
  breakfast.style.display = "block"
  lunchMeals.style.display = "none"
  dinner.style.display = "none"
};
breakfastBtn.onclick = function(){
  lunchMeals.style.display = "none"
  dinner.style.display = "none"
  breakfast.style.display = "block"
};
