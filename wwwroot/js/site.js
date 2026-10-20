// Small JS: header state on scroll + scroll-reveal. Everything else is Blazor + Tailwind.
(function () {
  const root = document.documentElement;
  const onScroll = () => root.classList.toggle("is-scrolled", window.scrollY > 48);
  onScroll();
  addEventListener("scroll", onScroll, { passive: true });

  const io = new IntersectionObserver(
    (entries) => entries.forEach((e) => {
      if (e.isIntersecting) { e.target.classList.add("is-visible"); io.unobserve(e.target); }
    }),
    { threshold: 0.12, rootMargin: "0px 0px -40px 0px" }
  );
  const scan = () => document.querySelectorAll("[data-reveal]:not([data-seen])").forEach((el) => {
    el.setAttribute("data-seen", "1");
    io.observe(el);
  });
  scan();
  new MutationObserver(scan).observe(document.documentElement, { childList: true, subtree: true });
})();
