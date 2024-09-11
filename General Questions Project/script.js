

const toggleButton = document.getElementById("toggle-btn");
const answers = document.getElementById("answers");

toggleButton.addEventListener("click", function() {
  answers.classList.toggle('active')
});
