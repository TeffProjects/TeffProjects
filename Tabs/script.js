
const history = document.getElementById('history');
const overview = document.getElementById('overview-btn');
const text = document.getElementById("txt");
const list_items = document.getElementById("list");

const tabs = [
  {
    title: "History",
    text: "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
  },
  {
    title: "Overview",
    text: "lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
  }
];

let currentItem = 0;

window.onload = function() {
  history.style.display = "flex"
}

overview.addEventListener("click", function() {
  const items = tabs[currentItem]
  heading.textContent = items.title
  txt.textContent = items.text
  list_items.style.display = "flex"
});
