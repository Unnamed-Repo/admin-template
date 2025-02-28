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

// Sidebar collapsed when small devices
const manageSidebar = () => {
  const sidebar = document.querySelector(".sidebar-wrapper");
  const appHeader = document.querySelector(".app-header");
  if (!sidebar) return; // Prevent errors if sidebar is missing

  const isSidebarClosed = sidebar.classList.contains("sidebar-fold");
  const isSmallScreen = window.innerWidth <= 1399;

  if (isSmallScreen && !isSidebarClosed) {
    sidebar.classList.add("sidebar-fold");
    appHeader.classList.add("sidebar-fold");
  } else if (isSidebarClosed || !isSmallScreen) {
    sidebar.classList.remove("sidebar-fold");
    appHeader.classList.remove("sidebar-fold");
  }
};
window.addEventListener("resize", manageSidebar);
document.addEventListener("DOMContentLoaded", manageSidebar);

document.addEventListener("DOMContentLoaded", () => {
  // Sidebar collapsed by click
  const collapseIcon = document.querySelector(".collapse-icon");
  const sidebar = document.querySelector(".sidebar-wrapper");

  if (collapseIcon && sidebar) {
    collapseIcon.addEventListener("click", () => {
      sidebar.classList.toggle("sidebar-fold");
    });
  }

  document
    .querySelector(".sidebar-menus")
    .addEventListener("mouseenter", function () {
      let sidebarWrapper = document.querySelector(".sidebar-wrapper");
      if (sidebarWrapper.classList.contains("sidebar-fold")) {
        sidebarWrapper.classList.remove("sidebar-fold");
        sidebarWrapper.classList.add("sidebar-uncollapsed");
      }
    });

  document
    .querySelector(".sidebar-menus")
    .addEventListener("mouseleave", function () {
      let sidebarWrapper = document.querySelector(".sidebar-wrapper");

      if (sidebarWrapper.classList.contains("sidebar-uncollapsed")) {
        sidebarWrapper.classList.remove("sidebar-uncollapsed");
        sidebarWrapper.classList.add("sidebar-fold");
      }
    });
});

// ToolTip
var tooltipTriggerList = [].slice.call(
  document.querySelectorAll('[data-bs-toggle="tooltip"]')
);
var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
  return new bootstrap.Tooltip(tooltipTriggerEl);
});

// Quick access menu number counter
const quickAccessItems = document.querySelectorAll(".quick-access-item");
const appStatisticsItems = document.querySelectorAll(".app-statistics-item");

function animateCounter(element, start, end, duration) {
  const range = end - start;
  const stepCount = 30;
  const increment = range / stepCount;
  const stepTime = duration / stepCount;
  let current = start;

  const timer = setInterval(() => {
    current += increment;

    if (current >= end) {
      element.textContent = end.toLocaleString();
      clearInterval(timer);
      return;
    }

    element.textContent = Math.round(current).toLocaleString();
  }, stepTime);
}

quickAccessItems.forEach((item) => {
  const countElement = item.querySelector(".count");
  const targetNumber = parseInt(countElement.textContent.replace(/,/g, ""));

  countElement.textContent = "0";
  animateCounter(countElement, 0, targetNumber, 2000);
});

appStatisticsItems.forEach((item) => {
  const countElement = item.querySelector(
    ".second-item .statistics h4 .counter"
  );
  const targetNumber = parseInt(countElement.textContent.replace(/,/g, ""));

  countElement.textContent = "0";
  animateCounter(countElement, 0, targetNumber, 2000);
});

// Init nice select
$(".nice-select").niceSelect();
