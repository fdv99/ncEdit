(TEST_FILE)
G90 G92X120.0787Y60.2362Z7.874
G93 X0.0Y0.0
M102()
G00 X1.3205 Y3.5005
M100
E4
G00 G41
M103
G01 X1.2505 Y3.5005
G03 X1.7505 Y3.5005 I0.2505 J0.0005
G03 X1.2505 Y3.5005 I-0.2505 J0.0005
G01 X1.3135 Y3.4705
M104
G00 G40
G00 X0.0005 Y0.0005
G00 X0.4125 Y0.4125
G00 G41
M103
G01 X0.5005 Y0.5005
G01 X0.5005 Y4.2505
G02 X0.7505 Y4.5005 I0.2505 J0.0005
G01 X2.5005 Y4.5005
G01 X2.5005 Y0.5005
G01 X0.5005 Y0.5005
G01 X0.3835 Y0.4575
M104
M101
G00 G40
G50
%
