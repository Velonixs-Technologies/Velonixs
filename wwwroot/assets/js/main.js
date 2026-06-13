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
  const params = new URLSearchParams(window.location.search);

  if (params.get("submitted") === "true") {
    alert("Thank you for your message. We will get back to you soon.");
    window.history.replaceState({}, document.title, window.location.pathname);
  }

  if (contactForm) {
    contactForm.addEventListener("submit", function (event) {
      if (!contactForm.checkValidity()) {
        event.preventDefault();
        event.stopPropagation();
        contactForm.classList.add("was-validated");
        return;
      }

      const submitButton = contactForm.querySelector('button[type="submit"]');
      if (submitButton) {
        submitButton.disabled = true;
        submitButton.textContent = "Sending...";
      }
    });
  }
});
