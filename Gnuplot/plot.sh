gnuplot << EOF
set term pngcairo size 1920,1080 enhanced
set datafile separator ","
set output 'output.png'
set title 'Balsa FPS'
set xlabel 'Time (s)'
set ylabel 'FPS'
set yrange [0:100]
set key off
plot 'FrameTimePlot.csv' using 1:3 with lines
EOF
okular output.png
