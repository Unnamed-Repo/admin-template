/*----------------------------------------*/
/* RockAdmin main jQuery
/*----------------------------------------*/

// Init lucide icons
lucide.createIcons();

// Submenu trigger
document.addEventListener("DOMContentLoaded", function () {
  const menuItems = document.querySelectorAll(".menu-item");

  menuItems.forEach((item) => {
    const menuLink = item.querySelector(".menu-link");

    if (menuLink) {
      menuLink.addEventListener("click", function (event) {
        event.preventDefault();

        // Close all other submenus
        menuItems.forEach((otherItem) => {
          if (otherItem !== item) {
            otherItem.classList.remove("show");
          }
        });

        // Toggle the current submenu
        item.classList.toggle("show");
      });
    }
  });

  // Close submenus when clicking outside
  document.addEventListener("click", function (event) {
    if (!event.target.closest(".menu-item")) {
      menuItems.forEach((item) => {
        item.classList.remove("show");
      });
    }
  });
});
