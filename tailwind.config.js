/** Heritage & Cultural palette: terracotta (amber-800/orange-900), cream (orange-50/stone-50), charcoal (slate-900). */
module.exports = {
  content: ["./Components/**/*.{razor,html}"],
  theme: {
    extend: {
      fontFamily: {
        display: ['"Cormorant Garamond"', "Georgia", "serif"],
        body: ['"Source Sans 3"', "system-ui", "sans-serif"],
      },
      transitionTimingFunction: {
        lux: "cubic-bezier(.22, 1, .36, 1)",
      },
      letterSpacing: { wider2: "0.22em" },
    },
  },
  plugins: [],
};
