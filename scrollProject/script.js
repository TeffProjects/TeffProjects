
const toggleButton = document.getElementById("toggle-btn");
const navLinks = document.getElementById("nav-links");

toggleButton.addEventListener("click", function() {
  navLinks.classList.toggle("active")
});
