

const openModal = document.getElementById("open-Modal");
const closeModal = document.getElementById("close-modal");
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
