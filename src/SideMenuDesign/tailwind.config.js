module.exports = {
    content: [
        "../SideMenuDesign/Components/**/*.{html,razor}"
    ],
    safelist: [
        'text-green-400',
        {
            pattern: /(text|bg|border)-(gray|red|orange|amber|yellow|lime|green|teal|sky|blue|indigo|purple|pink|rose)-(50|100|200|300|400|500|600|700|800|900|950)/,
            variants: ['hover'],
        }
    ],
    theme: {},
    plugins: [
        require('@tailwindcss/forms')
    ],
    darkMode: 'class'
}