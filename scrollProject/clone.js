const toggleButton = document.getElementById("toggle-btn");
const navLinks = document.getElementById("nav-links");
const toursButton = document.getElementById("tours-btn");

toggleButton.addEventListener("click", function() {
  navLinks.classList.toggle("active")
});

toursButton.addEventListener("click", function() {
  document.getElementById("tours").scrollIntoView({
    behavior: 'smooth'
  });
});
