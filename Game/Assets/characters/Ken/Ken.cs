using Character_Space;
using Animation_Space;
using Input_Space;
using Aux_Space;

public class Ken : Character {
    public Ken(string initialState, int startX, int startY)
        : base("Ken", initialState, startX, startY, "Assets/characters/Ken/sprites", "Assets/characters/Ken/sounds")
    {
        this.LifePoints = 1000;
        this.StunPoints = 50;

        this.move_speed = 10;
    }
    
    public override void Load() {
        // Hurtboxes
        var hurtbox1 = new GenericBox(1, 98, 92, 150, 141);
        var hurtbox3 = new GenericBox(1, 79, 141, 167, 195);

        var hitbox1 = new GenericBox(0, 0, 10, 10, 2);

        // Animations
        var idleFrames = new List<FrameData> {
            new FrameData(14657, 0, 0, new List<GenericBox> { new GenericBox(1, 102, 102, 140, 153), new GenericBox(1, 118, 92, 139, 109), new GenericBox(1, 137, 107, 156, 135), new GenericBox(1, 96, 105, 131, 127), new GenericBox(1, 91, 148, 152, 196), new GenericBox(2, 85, 178, 163, 197) }),
            new FrameData(14658, 0, 0, new List<GenericBox> { new GenericBox(1, 103, 101, 141, 153), new GenericBox(1, 95, 104, 155, 135), new GenericBox(1, 119, 91, 139, 108), new GenericBox(1, 91, 147, 154, 195), new GenericBox(2, 83, 177, 163, 197) }),
            new FrameData(14659, 0, 0, new List<GenericBox> { new GenericBox(1, 103, 97, 141, 149), new GenericBox(1, 118, 88, 140, 105), new GenericBox(1, 95, 98, 156, 131), new GenericBox(1, 91, 144, 154, 195), new GenericBox(2, 84, 179, 163, 198) }),
            new FrameData(14660, 0, 0, new List<GenericBox> { new GenericBox(1, 100, 96, 140, 149), new GenericBox(1, 119, 85, 139, 103), new GenericBox(1, 95, 97, 156, 128), new GenericBox(1, 92, 144, 152, 196), new GenericBox(2, 84, 178, 163, 197) }),
            new FrameData(14661, 0, 0, new List<GenericBox> { new GenericBox(2, 83, 179, 162, 196), new GenericBox(1, 118, 85, 139, 101), new GenericBox(1, 105, 94, 140, 147), new GenericBox(1, 91, 146, 153, 195), new GenericBox(1, 135, 97, 156, 127), new GenericBox(1, 96, 94, 129, 117) }),
            new FrameData(14662, 0, 0, new List<GenericBox> { new GenericBox(1, 118, 84, 138, 100), new GenericBox(1, 102, 94, 140, 146), new GenericBox(1, 96, 95, 157, 127), new GenericBox(1, 90, 142, 152, 195), new GenericBox(2, 84, 177, 163, 196) }),
            new FrameData(14663, 0, 0, new List<GenericBox> { new GenericBox(2, 84, 179, 163, 196), new GenericBox(1, 118, 84, 138, 101), new GenericBox(1, 103, 94, 140, 148), new GenericBox(1, 96, 96, 157, 128), new GenericBox(1, 91, 133, 153, 195) }),
            new FrameData(14664, 0, 0, new List<GenericBox> { new GenericBox(1, 118, 86, 138, 102), new GenericBox(1, 102, 94, 142, 148), new GenericBox(1, 96, 96, 157, 129), new GenericBox(1, 90, 141, 152, 195), new GenericBox(2, 84, 176, 163, 196) }),
            new FrameData(14665, 0, 0, new List<GenericBox> { new GenericBox(1, 119, 85, 139, 105), new GenericBox(1, 103, 94, 140, 148), new GenericBox(1, 96, 98, 156, 131), new GenericBox(1, 91, 141, 152, 195), new GenericBox(2, 84, 178, 163, 197) }),
            new FrameData(14666, 0, 0, new List<GenericBox> { new GenericBox(1, 119, 90, 140, 107), new GenericBox(1, 103, 99, 142, 153), new GenericBox(1, 96, 102, 157, 132), new GenericBox(1, 92, 139, 152, 196), new GenericBox(2, 84, 179, 163, 197) }),
        };

        var LPFrames = new List<FrameData> { 
            new FrameData(15008, 0, 0, new List<GenericBox> { new GenericBox(1, 105, 97, 144, 154), new GenericBox(1, 136, 103, 162, 129), new GenericBox(1, 91, 96, 125, 121), new GenericBox(1, 120, 87, 141, 105), new GenericBox(1, 87, 137, 162, 194), new GenericBox(2, 83, 177, 164, 195) }, "golpe_1"),
            new FrameData(15009, 0, 0, new List<GenericBox> { new GenericBox(0, 145, 100, 206, 119), new GenericBox(1, 142, 103, 204, 116), new GenericBox(1, 120, 87, 142, 105), new GenericBox(1, 88, 97, 116, 121), new GenericBox(1, 105, 98, 146, 153), new GenericBox(1, 88, 148, 158, 194), new GenericBox(2, 83, 177, 164, 195) }),
            new FrameData(15010, 0, 0, new List<GenericBox> { new GenericBox(0, 144, 99, 200, 119), new GenericBox(1, 139, 102, 199, 117), new GenericBox(1, 105, 96, 145, 154), new GenericBox(1, 120, 86, 145, 107), new GenericBox(1, 91, 96, 124, 122), new GenericBox(1, 89, 146, 159, 195), new GenericBox(2, 83, 175, 166, 196) }),
            new FrameData(15011, 0, 0, new List<GenericBox> { new GenericBox(1, 119, 87, 144, 107), new GenericBox(1, 139, 100, 178, 126), new GenericBox(1, 93, 99, 123, 122), new GenericBox(1, 105, 99, 145, 151), new GenericBox(1, 90, 145, 157, 194), new GenericBox(2, 83, 177, 164, 195) }),
            new FrameData(15012, 0, 0, new List<GenericBox> { new GenericBox(1, 120, 88, 142, 108), new GenericBox(1, 105, 98, 143, 153), new GenericBox(1, 139, 101, 160, 128), new GenericBox(1, 93, 99, 126, 122), new GenericBox(1, 88, 147, 155, 196), new GenericBox(2, 84, 179, 165, 199) }),
        };
        
        var MPFrames = new List<FrameData> {
            new FrameData(15013, 0, 0, new List<GenericBox> { new GenericBox(1, 100, 100, 146, 153), new GenericBox(1, 119, 89, 140, 106), new GenericBox(1, 85, 102, 111, 126), new GenericBox(1, 137, 102, 162, 129), new GenericBox(1, 91, 143, 154, 195), new GenericBox(2, 85, 177, 165, 195) }, "golpe_2"),
            new FrameData(15014, 0, 0, new List<GenericBox> { new GenericBox(1, 121, 90, 142, 108), new GenericBox(1, 105, 98, 147, 153), new GenericBox(1, 143, 116, 164, 134), new GenericBox(1, 84, 100, 110, 115), new GenericBox(1, 92, 139, 157, 195), new GenericBox(2, 83, 178, 165, 196) }),
            new FrameData(15015, 0, 0, new List<GenericBox> { new GenericBox(1, 125, 92, 148, 108), new GenericBox(1, 108, 108, 148, 157), new GenericBox(1, 146, 118, 161, 132), new GenericBox(1, 90, 102, 123, 119), new GenericBox(1, 93, 144, 164, 196), new GenericBox(2, 84, 179, 167, 196) }),
            new FrameData(15016, 0, 0, new List<GenericBox> { new GenericBox(1, 111, 104, 154, 157), new GenericBox(1, 127, 94, 154, 113), new GenericBox(1, 94, 143, 162, 195), new GenericBox(2, 83, 176, 164, 196), new GenericBox(1, 153, 109, 209, 123), new GenericBox(0, 153, 107, 212, 124) }),
            new FrameData(15017, 0, 0, new List<GenericBox> { new GenericBox(0, 163, 110, 204, 124), new GenericBox(1, 110, 103, 150, 161), new GenericBox(1, 129, 95, 152, 110), new GenericBox(1, 142, 107, 201, 122), new GenericBox(1, 91, 148, 160, 195), new GenericBox(2, 84, 177, 171, 197) }),
            new FrameData(15018, 0, 0, new List<GenericBox> { new GenericBox(2, 82, 179, 170, 195), new GenericBox(1, 106, 102, 145, 158), new GenericBox(1, 137, 105, 173, 128), new GenericBox(1, 123, 92, 146, 109), new GenericBox(1, 92, 144, 157, 195) }),
            new FrameData(15019, 0, 0, new List<GenericBox> { new GenericBox(1, 106, 99, 142, 156), new GenericBox(1, 96, 102, 156, 130), new GenericBox(1, 123, 90, 146, 106), new GenericBox(1, 89, 144, 160, 195), new GenericBox(2, 80, 177, 167, 196) }),
        };

        var BackMPFrames = new List<FrameData> {
            new FrameData(15020, 0, 0, new List<GenericBox> { new GenericBox(1, 101, 102, 157, 140), new GenericBox(1, 125, 92, 147, 109), new GenericBox(1, 95, 139, 166, 195), new GenericBox(2, 84, 174, 180, 195) }, "golpe_3"),
            new FrameData(15021, 0, 0, new List<GenericBox> { new GenericBox(2, 78, 174, 176, 196), new GenericBox(1, 108, 97, 146, 158), new GenericBox(1, 88, 150, 164, 195) }, "golpe_grito_2"),
            new FrameData(15022, 0, 0, new List<GenericBox> { new GenericBox(1, 105, 96, 142, 160), new GenericBox(1, 84, 116, 109, 135), new GenericBox(1, 84, 149, 163, 194), new GenericBox(2, 74, 177, 174, 197) }),
            new FrameData(15023, 0, 0, new List<GenericBox> { new GenericBox(2, 69, 179, 172, 197), new GenericBox(1, 113, 92, 136, 111), new GenericBox(1, 103, 103, 146, 159), new GenericBox(1, 85, 145, 161, 196), new GenericBox(1, 85, 110, 114, 127) }),
            new FrameData(15024, 0, 0, new List<GenericBox> { new GenericBox(1, 106, 95, 148, 156), new GenericBox(1, 94, 117, 111, 135), new GenericBox(1, 144, 101, 182, 113), new GenericBox(0, 144, 96, 191, 119), new GenericBox(0, 171, 93, 199, 121), new GenericBox(2, 68, 177, 174, 196), new GenericBox(1, 85, 150, 162, 195) }),
            new FrameData(15025, 0, 0, new List<GenericBox> { new GenericBox(0, 166, 92, 196, 116), new GenericBox(2, 67, 174, 168, 195), new GenericBox(1, 95, 96, 153, 143), new GenericBox(1, 143, 99, 189, 112), new GenericBox(1, 82, 142, 161, 193) }),
            new FrameData(15026, 0, 0, new List<GenericBox> { new GenericBox(1, 95, 99, 146, 156), new GenericBox(1, 132, 94, 167, 119), new GenericBox(1, 79, 144, 159, 194), new GenericBox(2, 66, 176, 168, 196) }),
            new FrameData(15027, 0, 0, new List<GenericBox> { new GenericBox(2, 72, 178, 172, 196), new GenericBox(1, 97, 98, 147, 158), new GenericBox(1, 85, 152, 161, 196) }),
            new FrameData(15028, 0, 0, new List<GenericBox> { new GenericBox(1, 106, 95, 128, 114), new GenericBox(1, 91, 110, 143, 162), new GenericBox(1, 85, 150, 162, 194), new GenericBox(2, 75, 178, 172, 197) }),
            new FrameData(15029, 0, 0, new List<GenericBox> { new GenericBox(2, 85, 179, 180, 196), new GenericBox(1, 116, 93, 138, 111), new GenericBox(1, 98, 104, 148, 154), new GenericBox(1, 92, 140, 167, 195) }),
        };

        var MKFrames = new List<FrameData> {
            new FrameData(15072, 10, 0, new List<GenericBox> { new GenericBox(1, 96, 102, 143, 150), new GenericBox(1, 82, 107, 100, 132), new GenericBox(1, 138, 124, 170, 150), new GenericBox(1, 114, 143, 148, 193), new GenericBox(1, 106, 92, 131, 106), new GenericBox(2, 83, 177, 160, 193)},  "golpe_3"),
            new FrameData(15073, 4, 0, new List<GenericBox> { new GenericBox(0, 176, 89, 210, 117), new GenericBox(0, 158, 105, 184, 126), new GenericBox(0, 139, 118, 166, 142), new GenericBox(1, 90, 93, 141, 146), new GenericBox(1, 110, 137, 137, 194), new GenericBox(1, 69, 114, 90, 136), new GenericBox(2, 68, 182, 167, 195) }, "golpe_grito_4"),
            new FrameData(15074, 4, 0, new List<GenericBox> { new GenericBox(0, 186, 95, 219, 120), new GenericBox(0, 162, 106, 189, 129), new GenericBox(0, 145, 117, 171, 140), new GenericBox(2, 83, 180, 168, 193), new GenericBox(1, 91, 91, 148, 140), new GenericBox(1, 112, 140, 139, 194), new GenericBox(1, 70, 120, 92, 140) }),
            new FrameData(15075, 4, 0, new List<GenericBox> { new GenericBox(0, 174, 118, 204, 144), new GenericBox(0, 145, 123, 174, 146), new GenericBox(2, 84, 179, 164, 194), new GenericBox(1, 93, 94, 148, 139), new GenericBox(1, 112, 137, 144, 193), new GenericBox(1, 79, 128, 101, 148) }),
            new FrameData(15076, 4, 0, new List<GenericBox> { new GenericBox(1, 109, 91, 131, 105), new GenericBox(1, 94, 96, 154, 140), new GenericBox(1, 135, 138, 176, 163), new GenericBox(1, 107, 141, 140, 193), new GenericBox(2, 88, 177, 164, 194) }),
            new FrameData(15077, 4, 0, new List<GenericBox> { new GenericBox(2, 87, 178, 158, 194), new GenericBox(1, 96, 92, 149, 145), new GenericBox(1, 106, 139, 144, 194) }),
            new FrameData(15078, 4, 0, new List<GenericBox> { new GenericBox(1, 102, 88, 124, 106), new GenericBox(1, 90, 100, 150, 132), new GenericBox(1, 100, 133, 141, 194), new GenericBox(2, 84, 179, 157, 194) }),
            new FrameData(15079, 4, 0, new List<GenericBox> { new GenericBox(2, 81, 179, 165, 195), new GenericBox(1, 109, 89, 131, 107), new GenericBox(1, 92, 101, 144, 148), new GenericBox(1, 96, 148, 145, 195) }),
            new FrameData(15080, 0, 0, new List<GenericBox> { new GenericBox(1, 117, 88, 137, 105), new GenericBox(1, 108, 100, 142, 151), new GenericBox(1, 95, 100, 153, 130), new GenericBox(1, 98, 143, 156, 195), new GenericBox(2, 80, 180, 168, 195) }),
            new FrameData(15081, 0, 0, new List<GenericBox> { new GenericBox(2, 87, 178, 164, 196), new GenericBox(1, 118, 88, 138, 107), new GenericBox(1, 102, 100, 142, 154), new GenericBox(1, 96, 104, 157, 131), new GenericBox(1, 94, 146, 155, 196) }),
            new FrameData(15082, 0, 0, new List<GenericBox> { new GenericBox(1, 122, 89, 140, 106), new GenericBox(1, 104, 99, 140, 153), new GenericBox(1, 97, 101, 159, 130), new GenericBox(1, 92, 143, 155, 195), new GenericBox(2, 82, 176, 163, 196) }),
        };

        var BackMKFrames = new List<FrameData> {
            new FrameData(15118, 0, 0, new List<GenericBox> { new GenericBox(1, 110, 86, 134, 103), new GenericBox(1, 100, 98, 141, 147), new GenericBox(1, 106, 132, 152, 193), new GenericBox(1, 88, 101, 157, 127), new GenericBox(2, 85, 169, 159, 195) }, "golpe_3"),
            new FrameData(15119, 0, 0, new List<GenericBox> { new GenericBox(2, 77, 177, 155, 193), new GenericBox(1, 76, 88, 154, 128), new GenericBox(1, 106, 116, 159, 194) }, "golpe_grito_5"),
            new FrameData(15120, 0, 0, new List<GenericBox> { new GenericBox(1, 106, 59, 137, 193), new GenericBox(1, 88, 91, 122, 129), new GenericBox(1, 68, 107, 95, 130), new GenericBox(2, 70, 177, 145, 193) }),
            new FrameData(15121, 0, 0, new List<GenericBox> { new GenericBox(2, 76, 179, 144, 193), new GenericBox(1, 108, 64, 140, 193), new GenericBox(1, 85, 89, 143, 134), new GenericBox(1, 75, 108, 93, 127) }),
            new FrameData(15122, 0, 0, new List<GenericBox> { new GenericBox(1, 108, 67, 144, 193), new GenericBox(2, 82, 178, 148, 193), new GenericBox(1, 86, 92, 147, 134) }),
            new FrameData(15123, 0, 0, new List<GenericBox> { new GenericBox(2, 90, 183, 156, 194), new GenericBox(0, 140, 68, 170, 97), new GenericBox(1, 94, 90, 151, 140), new GenericBox(1, 119, 140, 146, 193) }),            new FrameData(15124, 0, 0, new List<GenericBox> { new GenericBox(0, 164, 101, 211, 129), new GenericBox(0, 144, 113, 171, 138), new GenericBox(1, 93, 92, 148, 145), new GenericBox(1, 81, 111, 105, 147), new GenericBox(1, 116, 137, 151, 193), new GenericBox(2, 85, 177, 161, 193) }),
            new FrameData(15125, 0, 0, new List<GenericBox> { new GenericBox(0, 176, 132, 222, 160), new GenericBox(0, 152, 126, 183, 150), new GenericBox(1, 103, 95, 154, 149), new GenericBox(1, 122, 141, 162, 193), new GenericBox(1, 66, 111, 102, 148), new GenericBox(2, 91, 176, 171, 195) }),
            new FrameData(15126, 0, 0, new List<GenericBox> { new GenericBox(0, 165, 149, 191, 190), new GenericBox(1, 109, 95, 163, 152), new GenericBox(1, 79, 112, 109, 150), new GenericBox(1, 131, 150, 163, 193), new GenericBox(2, 106, 176, 168, 193) }),
            new FrameData(15127, 0, 0, new List<GenericBox> { new GenericBox(2, 91, 178, 169, 194), new GenericBox(1, 106, 98, 148, 148), new GenericBox(1, 122, 91, 148, 109), new GenericBox(1, 140, 101, 164, 126), new GenericBox(1, 86, 102, 115, 142), new GenericBox(1, 111, 136, 160, 194) }),
            new FrameData(15128, 0, 0, new List<GenericBox> { new GenericBox(2, 83, 174, 163, 194), new GenericBox(1, 106, 99, 147, 156), new GenericBox(1, 120, 89, 144, 107), new GenericBox(1, 94, 101, 163, 133), new GenericBox(1, 93, 145, 160, 194) }),
        };

        var LKFrames = new List<FrameData> {
            new FrameData(15104, 0, 0, new List<GenericBox> { new GenericBox(1, 124, 91, 145, 109), new GenericBox(1, 104, 96, 141, 155), new GenericBox(1, 139, 114, 156, 131), new GenericBox(1, 93, 144, 155, 195), new GenericBox(2, 86, 179, 163, 196) }, "golpe_1"),
            new FrameData(15105, 0, 0, new List<GenericBox> { new GenericBox(2, 101, 179, 167, 193), new GenericBox(1, 127, 92, 149, 107), new GenericBox(1, 105, 100, 153, 153), new GenericBox(1, 124, 152, 161, 193), new GenericBox(1, 149, 129, 171, 155) }),
            new FrameData(15106, 0, 0, new List<GenericBox> { new GenericBox(1, 125, 91, 149, 105), new GenericBox(1, 107, 100, 153, 147), new GenericBox(1, 121, 147, 157, 194), new GenericBox(1, 153, 129, 172, 157), new GenericBox(2, 103, 183, 173, 195), new GenericBox(0, 186, 154, 207, 181), new GenericBox(0, 171, 139, 187, 169) }),
            new FrameData(15107, 0, 0, new List<GenericBox> { new GenericBox(2, 109, 181, 167, 194), new GenericBox(1, 126, 91, 149, 105), new GenericBox(1, 104, 97, 155, 146), new GenericBox(1, 123, 140, 157, 193), new GenericBox(1, 151, 129, 174, 160) }),
            new FrameData(15108, 0, 0, new List<GenericBox> { new GenericBox(1, 128, 91, 148, 109), new GenericBox(1, 104, 99, 154, 150), new GenericBox(1, 127, 130, 163, 194), new GenericBox(2, 104, 182, 169, 193) }),
            new FrameData(15109, 0, 0, new List<GenericBox> { new GenericBox(2, 97, 177, 168, 194), new GenericBox(1, 128, 90, 148, 106), new GenericBox(1, 107, 99, 156, 154), new GenericBox(1, 108, 153, 159, 193) }),
            new FrameData(15110, 0, 0, new List<GenericBox> { new GenericBox(1, 122, 90, 141, 107), new GenericBox(1, 100, 97, 139, 153), new GenericBox(1, 137, 105, 156, 132), new GenericBox(1, 97, 143, 155, 195), new GenericBox(2, 85, 177, 162, 196) }),
        };

        var walkingForwardFrames = new List<FrameData> {
            new FrameData(14671, this.move_speed, 0, new List<GenericBox> { new GenericBox(2, 69, 182, 162, 196), new GenericBox(1, 120, 89, 140, 106), new GenericBox(1, 99, 97, 142, 156), new GenericBox(1, 84, 151, 152, 195), new GenericBox(1, 139, 103, 156, 139) }),
            new FrameData(14672, this.move_speed, 0, new List<GenericBox> { new GenericBox(1, 119, 88, 140, 108), new GenericBox(1, 98, 99, 148, 151), new GenericBox(1, 143, 106, 157, 138), new GenericBox(1, 74, 151, 149, 195), new GenericBox(2, 64, 179, 157, 195) }),
            new FrameData(14673, this.move_speed, 0, new List<GenericBox> { new GenericBox(2, 64, 177, 150, 195), new GenericBox(1, 119, 89, 141, 108), new GenericBox(1, 98, 101, 156, 138), new GenericBox(1, 72, 137, 145, 195) }),
            new FrameData(14674, this.move_speed, 0, new List<GenericBox> { new GenericBox(1, 117, 87, 139, 104), new GenericBox(1, 97, 96, 139, 148), new GenericBox(1, 139, 100, 155, 138), new GenericBox(1, 87, 142, 137, 192), new GenericBox(2, 79, 177, 148, 194) }),
            new FrameData(14675, this.move_speed, 0, new List<GenericBox> { new GenericBox(2, 84, 177, 145, 192), new GenericBox(1, 117, 85, 140, 102), new GenericBox(1, 99, 93, 156, 134), new GenericBox(1, 89, 134, 139, 191) }),
            new FrameData(14676, this.move_speed, 0, new List<GenericBox> { new GenericBox(1, 117, 84, 139, 102), new GenericBox(1, 97, 94, 138, 147), new GenericBox(1, 138, 97, 156, 135), new GenericBox(1, 92, 143, 138, 194), new GenericBox(2, 87, 175, 148, 194) }),
            new FrameData(14677, this.move_speed, 0, new List<GenericBox> { new GenericBox(2, 100, 178, 156, 195), new GenericBox(1, 116, 83, 140, 101), new GenericBox(1, 96, 94, 141, 134), new GenericBox(1, 139, 97, 158, 133), new GenericBox(1, 97, 134, 151, 195) }),
            new FrameData(14678, this.move_speed, 0, new List<GenericBox> { new GenericBox(1, 105, 94, 139, 148), new GenericBox(1, 118, 83, 138, 102), new GenericBox(1, 97, 96, 129, 117), new GenericBox(1, 138, 96, 157, 133), new GenericBox(1, 97, 141, 155, 195), new GenericBox(2, 94, 177, 159, 196) }),
            new FrameData(14679, this.move_speed, 0, new List<GenericBox> { new GenericBox(2, 89, 176, 170, 195), new GenericBox(1, 117, 83, 140, 101), new GenericBox(1, 97, 94, 141, 150), new GenericBox(1, 138, 98, 158, 133), new GenericBox(1, 93, 149, 169, 195) }),
            new FrameData(14680, this.move_speed, 0, new List<GenericBox> { new GenericBox(1, 117, 85, 139, 104), new GenericBox(1, 102, 94, 142, 149), new GenericBox(1, 97, 97, 155, 134), new GenericBox(1, 92, 142, 165, 195), new GenericBox(2, 86, 173, 176, 197) }),
            new FrameData(14681, this.move_speed, 0, new List<GenericBox> { new GenericBox(2, 75, 179, 170, 196), new GenericBox(1, 118, 88, 139, 105), new GenericBox(1, 105, 97, 141, 149), new GenericBox(1, 97, 103, 157, 139), new GenericBox(1, 84, 140, 162, 195) }),
        };

        var walkingBackwardFrames = new List<FrameData> {
            new FrameData(14683, -this.move_speed, 0, new List<GenericBox> { hurtbox1, hurtbox3 }),
            new FrameData(14684, -this.move_speed, 0, new List<GenericBox> { hurtbox1, hurtbox3 }),
            new FrameData(14685, -this.move_speed, 0, new List<GenericBox> { hurtbox1, hurtbox3 }),
            new FrameData(14686, -this.move_speed, 0, new List<GenericBox> { hurtbox1, hurtbox3 }),
            new FrameData(14687, -this.move_speed, 0, new List<GenericBox> { hurtbox1, hurtbox3 }),
            new FrameData(14688, -this.move_speed, 0, new List<GenericBox> { hurtbox1, hurtbox3 }),
            new FrameData(14689, -this.move_speed, 0, new List<GenericBox> { hurtbox1, hurtbox3 }),
            new FrameData(14690, -this.move_speed, 0, new List<GenericBox> { hurtbox1, hurtbox3 }),
            new FrameData(14691, -this.move_speed, 0, new List<GenericBox> { hurtbox1, hurtbox3 }),
            new FrameData(14692, -this.move_speed, 0, new List<GenericBox> { hurtbox1, hurtbox3 }),
            new FrameData(14693, -this.move_speed, 0, new List<GenericBox> { hurtbox1, hurtbox3 })
        };

        var dashForwardFrames = new List<FrameData> {
            new FrameData(14768, 15, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(14769, 15, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(14770, 15, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(14771, 15, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(14772, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(14773, 0, 0, new List<GenericBox> { hurtbox1 })
        };

        var dashBackwardFrames = new List<FrameData> {
            new FrameData(14774, -15, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(14775, -15, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(14776, -15, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(14777, -15, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(14778, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(14779, 0, 0, new List<GenericBox> { hurtbox1 })
        };

        var crouchingInFrames = new List<FrameData> {
            new FrameData(14696, 0, 0, new List<GenericBox> { new GenericBox(1, 102, 99, 143, 154), new GenericBox(1, 132, 105, 156, 134), new GenericBox(1, 94, 101, 130, 122), new GenericBox(1, 117, 89, 140, 107), new GenericBox(1, 90, 137, 158, 195), new GenericBox(2, 84, 177, 164, 196) }),
            new FrameData(14697, 0, 0, new List<GenericBox> { new GenericBox(1, 103, 115, 147, 164), new GenericBox(1, 98, 116, 135, 145), new GenericBox(1, 134, 120, 159, 152), new GenericBox(1, 91, 150, 162, 195), new GenericBox(2, 83, 175, 170, 197) }),
            new FrameData(14698, 0, 0, new List<GenericBox> { new GenericBox(1, 98, 132, 163, 196), new GenericBox(2, 83, 175, 171, 198) }),
            new FrameData(14699, 0, 0, new List<GenericBox> { new GenericBox(1, 96, 131, 160, 195), new GenericBox(2, 83, 174, 173, 197) }),
        };

        var crouchingFrames = new List<FrameData> {
            new FrameData(14704, 0, 0, new List<GenericBox> { new GenericBox(1, 96, 131, 160, 195), new GenericBox(2, 83, 174, 173, 197) }),
            new FrameData(14705, 0, 0, new List<GenericBox> { new GenericBox(1, 96, 131, 160, 195), new GenericBox(2, 83, 174, 173, 197) }),
            new FrameData(14706, 0, 0, new List<GenericBox> { new GenericBox(1, 96, 131, 160, 195), new GenericBox(2, 83, 174, 173, 197) }),
            new FrameData(14707, 0, 0, new List<GenericBox> { new GenericBox(1, 96, 131, 160, 195), new GenericBox(2, 83, 174, 173, 197) }),
        };

        var crouchingOutFrames = new List<FrameData> {
            new FrameData(14700, 0, 0, new List<GenericBox> { new GenericBox(1, 116, 122, 140, 142), new GenericBox(1, 95, 132, 159, 196), new GenericBox(2, 83, 176, 171, 198) }),
            new FrameData(14701, 0, 0, new List<GenericBox> { new GenericBox(2, 83, 179, 172, 197), new GenericBox(1, 97, 128, 160, 196), new GenericBox(1, 119, 118, 141, 137) }),
            new FrameData(14702, 0, 0, new List<GenericBox> { new GenericBox(1, 97, 98, 157, 135), new GenericBox(1, 117, 86, 139, 102), new GenericBox(1, 107, 98, 139, 152), new GenericBox(1, 90, 142, 154, 194), new GenericBox(2, 84, 179, 162, 197) }),
        };

        var heavyHadukenFrames = new List<FrameData> {
            new FrameData(15328, 0, 0, new List<GenericBox> { hurtbox1 }, "haduken"),
            new FrameData(15329, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15330, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15331, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15332, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15333, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15334, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15335, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15336, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15337, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15338, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15339, 0, 0, new List<GenericBox> { hurtbox1 })
        };

        var lightHadukenFrames = new List<FrameData> {
            new FrameData(15329, 0, 0, new List<GenericBox> { hurtbox1 }, "haduken"),
            new FrameData(15330, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15331, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15333, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15334, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15335, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15336, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15337, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15338, 0, 0, new List<GenericBox> { hurtbox1 }),
        };

        var heavyShoryFrames = new List<FrameData> {
            new FrameData(15342, 0, 0, new List<GenericBox> { hurtbox1 }, "shory"),
            new FrameData(15343, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15344, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15345, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15346, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15347, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15348, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15349, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15350, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15351, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15352, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15353, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15354, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15355, 0, 0, new List<GenericBox> { hurtbox1 })
        };

        var lightShoryFrames = new List<FrameData> {
            new FrameData(15345, 0, 0, new List<GenericBox> { hurtbox1 }, "shory"),
            new FrameData(15346, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15347, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15348, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15349, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15350, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15351, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15352, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15353, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15354, 0, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15355, 0, 0, new List<GenericBox> { hurtbox1 })
        };

        var heavyTatsoFrames = new List<FrameData> {
            new FrameData(15356, 7, 0, new List<GenericBox> { hurtbox1 }, "tatso"),
            new FrameData(15357, 7, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15358, 7, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15359, 7, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15457, 7, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15458, 7, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15459, 7, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15460, 7, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15461, 7, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15457, 7, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15458, 7, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15459, 7, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15460, 7, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15461, 7, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15366, 7, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15367, 7, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15368, 7, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15369, 7, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15370, 7, 0, new List<GenericBox> { hurtbox1 })
        };

        var lightTatsoFrames = new List<FrameData> {
            new FrameData(15356, 6, 0, new List<GenericBox> { hurtbox1 }, "tatso"),
            new FrameData(15357, 6, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15358, 6, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15359, 6, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15457, 6, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15458, 6, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15459, 6, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15460, 6, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15461, 6, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15366, 6, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15367, 6, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15368, 6, 0, new List<GenericBox> { hurtbox1 }),
            new FrameData(15369, 6, 0, new List<GenericBox> { hurtbox1 })
        };
        
        // States
        var animations = new Dictionary<string, Animation> {
            // Normals
            { "Idle", new Animation(idleFrames, "Idle", 20)},
            { "AAttack", new Animation(LPFrames, "Idle", 24)},
            { "BAttack", new Animation(LKFrames, "Idle", 24)},
            { "CAttack", new Animation(MPFrames, "Idle", 20)},
            { "DAttack", new Animation(MKFrames, "Idle", 20)},
            { "BackDAttack", new Animation(BackMKFrames, "Idle", 20)},
            { "BackCAttack", new Animation(BackMPFrames, "Idle", 20)},
            // Movment
            { "WalkingForward", new Animation(walkingForwardFrames, "Idle", 20)},
            { "WalkingBackward", new Animation(walkingBackwardFrames, "Idle", 20)},
            { "DashForward", new Animation(dashForwardFrames, "Idle", 20)},
            { "DashBackward", new Animation(dashBackwardFrames, "Idle", 20)},
            { "CrouchingIn", new Animation(crouchingInFrames, "Crouching", 20)},
            { "Crouching", new Animation(crouchingFrames, "CrouchingOut", 4)},
            { "CrouchingOut", new Animation(crouchingOutFrames, "Idle", 20)},
            // Specials
            { "LightShory", new Animation(lightShoryFrames, "Idle", 20)},
            { "HeavyShory", new Animation(heavyShoryFrames, "Idle", 20)},
            { "LightHaduken", new Animation(lightHadukenFrames, "Idle", 20)},
            { "HeavyHaduken", new Animation(heavyHadukenFrames, "Idle", 20)},
            { "LightTatso", new Animation(lightTatsoFrames, "Idle", 30)},
            { "HeavyTatso", new Animation(heavyTatsoFrames, "Idle", 30)}
        };

        this.animations = animations;
        this.LoadSpriteImages();
        this.LoadSounds();
    }

    public override void DoBehavior() {
        if ((this.CurrentState == "WalkingForward" || this.CurrentState == "WalkingBackward") & !InputManager.Instance.Key_hold(8) & !InputManager.Instance.Key_hold(9)) {
            this.ChangeState("Idle");
        }

        // Specials
        int[] light_shory_string = {9, 7, 9, 0};
        int[] heavy_shory_string = {9, 7, 9, 2};
        int[] light_haduken_string = {7, 9, 0};
        int[] heavy_haduken_string = {7, 9, 2};
        int[] light_tatso_string = {7, 8, 1};
        int[] heavy_tatso_string = {7, 8, 3};

        if (InputManager.Instance.CheckString(light_shory_string, 10) && this.canNormalAtack) {
            this.ChangeState("LightShory");
        } else if (InputManager.Instance.CheckString(heavy_shory_string, 10) && this.canNormalAtack) {
            this.ChangeState("HeavyShory");
        }

        if (InputManager.Instance.CheckString(light_haduken_string, 10) && this.canNormalAtack) {
            this.ChangeState("LightHaduken");
        } else if (InputManager.Instance.CheckString(heavy_haduken_string, 10) && this.canNormalAtack) {
            this.ChangeState("HeavyHaduken");
        }

        if (InputManager.Instance.CheckString(light_tatso_string, 10) && this.canNormalAtack) {
            this.ChangeState("LightTatso");
        } else if (InputManager.Instance.CheckString(heavy_tatso_string, 10) && this.canNormalAtack) {
            this.ChangeState("HeavyTatso");
        }

        // Cancels
        if (InputManager.Instance.Key_down(3) && this.CurrentState == "BAttack" && this.CurrentFrameIndex >= 3) {
            this.ChangeState("DAttack");
        }
        if (InputManager.Instance.Key_down(2) && InputManager.Instance.Key_hold(8) && this.CurrentState == "CAttack" && this.CurrentFrameIndex >= 4) {
            this.ChangeState("BackCAttack");
        }

        // Normals
        if (InputManager.Instance.Key_down(3) && InputManager.Instance.Key_hold(8) && this.canNormalAtack) {
            this.ChangeState("BackDAttack");
        } else if (InputManager.Instance.Key_down(2) && InputManager.Instance.Key_hold(8) && this.canNormalAtack) {
            this.ChangeState("BackCAttack");
        }

        if (InputManager.Instance.Key_down(0) && this.canNormalAtack) {
            this.ChangeState("AAttack");
        } else if (InputManager.Instance.Key_down(1) && this.canNormalAtack) {
            this.ChangeState("BAttack");
        } else if (InputManager.Instance.Key_down(2) && this.canNormalAtack) {
            this.ChangeState("CAttack");
        } else if (InputManager.Instance.Key_down(3) && this.canNormalAtack ) {
            this.ChangeState("DAttack");
        }

        // Crouching
        if (InputManager.Instance.Key_hold(7) && !InputManager.Instance.Key_hold(6) && (this.CurrentState == "Idle" || this.CurrentState == "WalkingForward" || this.CurrentState == "WalkingBackward")) {
            this.ChangeState("CrouchingIn");
        }
        if (this.CurrentState == "Crouching" && !InputManager.Instance.Key_hold(7)) {
            this.ChangeState("CrouchingOut");
        }
        if (this.CurrentState == "CrouchingOut" && InputManager.Instance.Key_hold(7) && !InputManager.Instance.Key_hold(6)) {
            this.ChangeState("Crouching");
        }

        // Dashing
        int[] dash_forward_string = {9, 9}; 
        int[] dash_backward_string = {8, 8};
        if (InputManager.Instance.CheckString(dash_forward_string, 13) && (this.CurrentState == "Idle" || this.CurrentState == "WalkingForward" || this.CurrentState == "WalkingBackward")) {
            this.ChangeState("DashForward");
        } 
        else if (InputManager.Instance.CheckString(dash_backward_string, 13) && (this.CurrentState == "Idle" || this.CurrentState == "WalkingForward" || this.CurrentState == "WalkingBackward")) {
            this.ChangeState("DashBackward");
        }

        // Walking
        if (InputManager.Instance.Key_hold(8) && !InputManager.Instance.Key_hold(9) && (this.CurrentState == "Idle" || this.CurrentState == "WalkingForward" || this.CurrentState == "WalkingBackward")) {
            this.ChangeState("WalkingBackward");
        } else if (InputManager.Instance.Key_hold(9) && !InputManager.Instance.Key_hold(8) && (this.CurrentState == "Idle" || this.CurrentState == "WalkingBackward" || this.CurrentState == "WalkingForward")) {
            this.ChangeState("WalkingForward");
        }

        // On Air
        if (this.CurrentState == "LightShory") {
            this.PositionY = this.floorLine - Physics.GetTrajectory(100, 8, this.CurrentFrameIndex - 2);
        } else if (this.CurrentState == "HeavyShory") {
            this.PositionY = this.floorLine - Physics.GetTrajectory(150, 8, this.CurrentFrameIndex - 5);
        } else if (this.CurrentState == "Airboned" || this.CurrentState == "Jump" || this.CurrentState == "JumpIn" || this.CurrentState == "JumpOut") {
            this.PositionY = this.floorLine - Physics.GetTrajectory(120, 15, this.CurrentFrameIndex);
        }
    }
}