

const openModal = document.getElementById("openModal");
const closeModal = document.getElementById("closeModal");

const modal = document.getElementById("myModal");

openModal.onclick = function() {
  modal.style.display = "block";
}

closeModal.onclick = function() {
  modal.style.display = "none";
}

window.onclick = function(event) {
  if(event.target === modal){
    modal.style.display = "none";
  }
}
