document.addEventListener("DOMContentLoaded", function () {
  const currentPath = window.location.pathname.replace(/\/$/, "") || "/";

  document.querySelectorAll(".navbar-nav .nav-link").forEach(function (link) {
    const linkPath = new URL(link.getAttribute("href"), window.location.origin).pathname.replace(/\/$/, "") || "/";

    if (linkPath === currentPath) {
      link.classList.add("active");
      link.setAttribute("aria-current", "page");
    }
  });

  document.querySelectorAll('a[href^="#"]').forEach(function (anchor) {
    anchor.addEventListener("click", function (event) {
      const target = document.querySelector(anchor.getAttribute("href"));
      if (target) {
        event.preventDefault();
        target.scrollIntoView({ behavior: "smooth", block: "start" });
      }
    });
  });

  const contactForm = document.getElementById("contactForm");
  if (contactForm) {
    contactForm.addEventListener("submit", function (event) {
      event.preventDefault();

      if (!contactForm.checkValidity()) {
        contactForm.classList.add("was-validated");
        return;
      }

      alert("Thank you for your message. We will get back to you soon.");
      contactForm.reset();
      contactForm.classList.remove("was-validated");
    });
  }
});
